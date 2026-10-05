using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu
{
	// Token: 0x02001440 RID: 5184
	[Token(Token = "0x2001440")]
	public class ValidStageEnumerator : IEnumerator<KeyValuePair<string, StageData>>, IEnumerator, IDisposable, IHotfixable
	{
		// Token: 0x060077E7 RID: 30695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60077E7")]
		[Address(RVA = "0x2551760", Offset = "0x2550360", VA = "0x182551760")]
		public ValidStageEnumerator(long targetTs, IEnumerator<KeyValuePair<string, StageData>> rawEnum)
		{
		}

		// Token: 0x17000E5A RID: 3674
		// (get) Token: 0x060077E8 RID: 30696 RVA: 0x00035CE8 File Offset: 0x00033EE8
		[Token(Token = "0x17000E5A")]
		public KeyValuePair<string, StageData> Current
		{
			[Token(Token = "0x60077E8")]
			[Address(RVA = "0x25517F0", Offset = "0x25503F0", VA = "0x1825517F0", Slot = "4")]
			get
			{
				return default(KeyValuePair<string, StageData>);
			}
		}

		// Token: 0x17000E5B RID: 3675
		// (get) Token: 0x060077E9 RID: 30697 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E5B")]
		private object Current
		{
			[Token(Token = "0x60077E9")]
			[Address(RVA = "0x25516E0", Offset = "0x25502E0", VA = "0x1825516E0", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x060077EA RID: 30698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60077EA")]
		[Address(RVA = "0x2551460", Offset = "0x2550060", VA = "0x182551460", Slot = "5")]
		public void Dispose()
		{
		}

		// Token: 0x060077EB RID: 30699 RVA: 0x00035D00 File Offset: 0x00033F00
		[Token(Token = "0x60077EB")]
		[Address(RVA = "0x2551500", Offset = "0x2550100", VA = "0x182551500", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x060077EC RID: 30700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60077EC")]
		[Address(RVA = "0x2551650", Offset = "0x2550250", VA = "0x182551650", Slot = "8")]
		public void Reset()
		{
		}

		// Token: 0x04007595 RID: 30101
		[Token(Token = "0x4007595")]
		[FieldOffset(Offset = "0x10")]
		private long m_targetTs;

		// Token: 0x04007596 RID: 30102
		[Token(Token = "0x4007596")]
		[FieldOffset(Offset = "0x18")]
		private KeyValuePair<string, StageData> m_current;

		// Token: 0x04007597 RID: 30103
		[Token(Token = "0x4007597")]
		[FieldOffset(Offset = "0x28")]
		private IEnumerator<KeyValuePair<string, StageData>> m_rawEnum;

		// Token: 0x04007598 RID: 30104
		[Token(Token = "0x4007598")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04007599 RID: 30105
		[Token(Token = "0x4007599")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_Current;

		// Token: 0x0400759A RID: 30106
		[Token(Token = "0x400759A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge get_Current;

		// Token: 0x0400759B RID: 30107
		[Token(Token = "0x400759B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Dispose;

		// Token: 0x0400759C RID: 30108
		[Token(Token = "0x400759C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_MoveNext;

		// Token: 0x0400759D RID: 30109
		[Token(Token = "0x400759D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Reset;
	}
}
