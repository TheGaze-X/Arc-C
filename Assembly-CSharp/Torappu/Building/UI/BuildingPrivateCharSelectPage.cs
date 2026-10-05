using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Building.UI
{
	// Token: 0x02001B8C RID: 7052
	[Token(Token = "0x2001B8C")]
	public class BuildingPrivateCharSelectPage : BuildingCommonPage
	{
		// Token: 0x0600B052 RID: 45138 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B052")]
		[Address(RVA = "0x32A4EB0", Offset = "0x32A3AB0", VA = "0x1832A4EB0", Slot = "25")]
		protected override IEnumerator EffectsOnShow(bool isFromStack)
		{
			return null;
		}

		// Token: 0x0600B053 RID: 45139 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B053")]
		[Address(RVA = "0x32A4DD0", Offset = "0x32A39D0", VA = "0x1832A4DD0", Slot = "26")]
		protected override IEnumerator EffectsOnHide(bool isToStack, bool isRemoveVirtualTop)
		{
			return null;
		}

		// Token: 0x0600B054 RID: 45140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B054")]
		[Address(RVA = "0x32A4F70", Offset = "0x32A3B70", VA = "0x1832A4F70")]
		public BuildingPrivateCharSelectPage()
		{
		}

		// Token: 0x0600B055 RID: 45141 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B055")]
		[Address(RVA = "0x119B2F0", Offset = "0x1199EF0", VA = "0x18119B2F0")]
		private IEnumerator <>xLuaBaseProxy_EffectsOnShow(bool P0)
		{
			return null;
		}

		// Token: 0x0600B056 RID: 45142 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B056")]
		[Address(RVA = "0x12172E0", Offset = "0x1215EE0", VA = "0x1812172E0")]
		private IEnumerator <>xLuaBaseProxy_EffectsOnHide(bool P0, bool P1)
		{
			return null;
		}

		// Token: 0x0400AABD RID: 43709
		[Token(Token = "0x400AABD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_EffectsOnShow;

		// Token: 0x0400AABE RID: 43710
		[Token(Token = "0x400AABE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EffectsOnHide;

		// Token: 0x0400AABF RID: 43711
		[Token(Token = "0x400AABF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001B8D RID: 7053
		[Token(Token = "0x2001B8D")]
		public new struct Param
		{
			// Token: 0x170014DE RID: 5342
			// (get) Token: 0x0600B057 RID: 45143 RVA: 0x00043680 File Offset: 0x00041880
			[Token(Token = "0x170014DE")]
			public bool isEmpty
			{
				[Token(Token = "0x600B057")]
				[Address(RVA = "0x7F69A0", Offset = "0x7F55A0", VA = "0x1807F69A0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0400AAC0 RID: 43712
			[Token(Token = "0x400AAC0")]
			[FieldOffset(Offset = "0x0")]
			public string slotId;

			// Token: 0x0400AAC1 RID: 43713
			[Token(Token = "0x400AAC1")]
			[FieldOffset(Offset = "0x8")]
			public int maxSelectCount;

			// Token: 0x0400AAC2 RID: 43714
			[Token(Token = "0x400AAC2")]
			[FieldOffset(Offset = "0x10")]
			public List<int> selectedCharInstIds;
		}
	}
}
