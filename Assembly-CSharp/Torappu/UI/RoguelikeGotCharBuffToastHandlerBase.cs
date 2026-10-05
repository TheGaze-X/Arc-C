using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003B0C RID: 15116
	[Token(Token = "0x2003B0C")]
	public abstract class RoguelikeGotCharBuffToastHandlerBase : IHotfixable
	{
		// Token: 0x06017CF1 RID: 97521
		[Token(Token = "0x6017CF1")]
		public abstract void ShowBuffToast(string topicId, RoguelikeTopicDetail topicData, List<string> charNames, string buffId);

		// Token: 0x06017CF2 RID: 97522 RVA: 0x000985F8 File Offset: 0x000967F8
		[Token(Token = "0x6017CF2")]
		[Address(RVA = "0x100B200", Offset = "0x1009E00", VA = "0x18100B200")]
		protected bool ValidateParams(string topicId, RoguelikeTopicDetail topicData, List<string> charNames)
		{
			return default(bool);
		}

		// Token: 0x06017CF3 RID: 97523 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6017CF3")]
		[Address(RVA = "0x100B020", Offset = "0x1009C20", VA = "0x18100B020", Slot = "5")]
		protected virtual string BuildCharBuffString(List<string> charNames)
		{
			return null;
		}

		// Token: 0x06017CF4 RID: 97524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017CF4")]
		[Address(RVA = "0x100B2C0", Offset = "0x1009EC0", VA = "0x18100B2C0")]
		protected RoguelikeGotCharBuffToastHandlerBase()
		{
		}

		// Token: 0x0401CC25 RID: 117797
		[Token(Token = "0x401CC25")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ValidateParams;

		// Token: 0x0401CC26 RID: 117798
		[Token(Token = "0x401CC26")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_BuildCharBuffString;

		// Token: 0x0401CC27 RID: 117799
		[Token(Token = "0x401CC27")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
