using System;
			imports.Add("System.Collections");
			imports.Add("Zeus");
			imports.Add("Zeus.DotNetScript");
			if (isGui) 
			{
					imports.Add("Zeus.UserInterface");
			}

			foreach (ZeusScriptableObject obj in ZeusFactory.ScriptableObjects) 
			{
				{
						imports.Add(obj.Namespace);
			{
				if (obj is String[]) 
				{
					array = (string[])obj;
					if ((array.Length == 2) && (array[0] == DotNetScriptEngine.USE_NAMESPACE))
					{
						if (!imports.Contains(array[1]))
							imports.Add(array[1]);
					}
				}
			}
			{
			else
			{