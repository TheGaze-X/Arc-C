using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Resource;

namespace Torappu.AVG
{
	// Token: 0x02001E6D RID: 7789
	[Token(Token = "0x2001E6D")]
	public class AVGVariableConfig : IAVGVariableConverter
	{
		// Token: 0x0600C112 RID: 49426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C112")]
		[Address(RVA = "0x33E6810", Offset = "0x33E5410", VA = "0x1833E6810")]
		public void TryLoadConfig(DirectAssetLoader loader)
		{
		}

		// Token: 0x17001736 RID: 5942
		// (get) Token: 0x0600C113 RID: 49427 RVA: 0x00046F38 File Offset: 0x00045138
		[Token(Token = "0x17001736")]
		public bool available
		{
			[Token(Token = "0x600C113")]
			[Address(RVA = "0x1028420", Offset = "0x1027020", VA = "0x181028420")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600C114 RID: 49428 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C114")]
		[Address(RVA = "0x33E6670", Offset = "0x33E5270", VA = "0x1833E6670", Slot = "4")]
		public object Convert(object src)
		{
			return null;
		}

		// Token: 0x0600C115 RID: 49429 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C115")]
		[Address(RVA = "0x33E6790", Offset = "0x33E5390", VA = "0x1833E6790")]
		public object GetVariable(string key)
		{
			return null;
		}

		// Token: 0x0600C116 RID: 49430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C116")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public AVGVariableConfig()
		{
		}

		// Token: 0x0400C294 RID: 49812
		[Token(Token = "0x400C294")]
		public const string VARIABLE_PROMPT = "$";

		// Token: 0x0400C295 RID: 49813
		[Token(Token = "0x400C295")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<string, object> m_variableMap;
	}
}
