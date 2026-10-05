using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm
{
	// Token: 0x0200400D RID: 16397
	[Token(Token = "0x200400D")]
	public class SandboxPermTopicEntryResHolder : MonoBehaviour, IHotfixable
	{
		// Token: 0x06019652 RID: 104018 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019652")]
		[Address(RVA = "0x1219210", Offset = "0x1217E10", VA = "0x181219210")]
		public Sprite GetHomeEntry()
		{
			return null;
		}

		// Token: 0x06019653 RID: 104019 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019653")]
		[Address(RVA = "0x12191B0", Offset = "0x1217DB0", VA = "0x1812191B0")]
		public Sprite GetHomeEntryMultiMode()
		{
			return null;
		}

		// Token: 0x06019654 RID: 104020 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019654")]
		[Address(RVA = "0x1219270", Offset = "0x1217E70", VA = "0x181219270")]
		public Sprite GetZoneHomeDailySprite()
		{
			return null;
		}

		// Token: 0x06019655 RID: 104021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019655")]
		[Address(RVA = "0x12192D0", Offset = "0x1217ED0", VA = "0x1812192D0")]
		public SandboxPermTopicEntryResHolder()
		{
		}

		// Token: 0x0401F97B RID: 129403
		[Token(Token = "0x401F97B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Sprite _homeEntry;

		// Token: 0x0401F97C RID: 129404
		[Token(Token = "0x401F97C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Sprite _homeEntryMultiMode;

		// Token: 0x0401F97D RID: 129405
		[Token(Token = "0x401F97D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Sprite _zoneHomeDaily;

		// Token: 0x0401F97E RID: 129406
		[Token(Token = "0x401F97E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetHomeEntry;

		// Token: 0x0401F97F RID: 129407
		[Token(Token = "0x401F97F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetHomeEntryMultiMode;

		// Token: 0x0401F980 RID: 129408
		[Token(Token = "0x401F980")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetZoneHomeDailySprite;

		// Token: 0x0401F981 RID: 129409
		[Token(Token = "0x401F981")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
