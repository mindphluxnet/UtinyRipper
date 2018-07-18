﻿using System.IO;

namespace UtinyRipper.Classes.Shaders.Exporters
{
	public abstract class ShaderTextExporter
	{
		public virtual void Export(BinaryReader reader, TextWriter writer)
		{
			while (reader.BaseStream.Position != reader.BaseStream.Length)
			{
				char c = reader.ReadChar();
				if (c == '\n')
				{
					if (reader.BaseStream.Position == reader.BaseStream.Length)
					{
						break;
					}
					writer.Write(c);
					writer.WriteIntent(5);
				}
				else
				{
					writer.Write(c);
				}
			}
		}
	}
}
