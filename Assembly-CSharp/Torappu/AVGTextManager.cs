using System;
using Il2CppDummyDll;
using Torappu.AVG;
using XLua;

namespace Torappu
{
	// Token: 0x02000482 RID: 1154
	[Token(Token = "0x2000482")]
	public class AVGTextManager : Singleton<AVGTextManager>
	{
		// Token: 0x06004C70 RID: 19568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C70")]
		[Address(RVA = "0x177F3E0", Offset = "0x177DFE0", VA = "0x18177F3E0")]
		private AVGTextManager()
		{
		}

		// Token: 0x06004C71 RID: 19569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C71")]
		[Address(RVA = "0x177F100", Offset = "0x177DD00", VA = "0x18177F100")]
		public void InjectVariableConfig(AVGVariableConfig config)
		{
		}

		// Token: 0x06004C72 RID: 19570 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C72")]
		[Address(RVA = "0x177F230", Offset = "0x177DE30", VA = "0x18177F230")]
		public string Translate(string content)
		{
			return null;
		}

		// Token: 0x04001074 RID: 4212
		[Token(Token = "0x4001074")]
		[FieldOffset(Offset = "0x10")]
		private IAVGTextTranslater m_translater;

		// Token: 0x04001075 RID: 4213
		[Token(Token = "0x4001075")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04001076 RID: 4214
		[Token(Token = "0x4001076")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_InjectVariableConfig;

		// Token: 0x04001077 RID: 4215
		[Token(Token = "0x4001077")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Translate;
	}
}
