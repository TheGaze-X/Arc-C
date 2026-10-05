using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.AVG
{
	// Token: 0x02001EAC RID: 7852
	[Token(Token = "0x2001EAC")]
	public class AVGShowItemPanel : ExecutorComponent, IContainsResRefs
	{
		// Token: 0x0600C27E RID: 49790 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C27E")]
		[Address(RVA = "0x33FBD00", Offset = "0x33FA900", VA = "0x1833FBD00", Slot = "8")]
		public override Dictionary<string, ExecutorComponent.Executor> GetExecutors()
		{
			return null;
		}

		// Token: 0x0600C27F RID: 49791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C27F")]
		[Address(RVA = "0x33FBE90", Offset = "0x33FAA90", VA = "0x1833FBE90", Slot = "7")]
		public override void OnReset()
		{
		}

		// Token: 0x0600C280 RID: 49792 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C280")]
		[Address(RVA = "0x33FBC10", Offset = "0x33FA810", VA = "0x1833FBC10", Slot = "13")]
		public AbstractResRefCollecter DontInvoke_PlzImplInternalResRefCollector()
		{
			return null;
		}

		// Token: 0x0600C281 RID: 49793 RVA: 0x000475F8 File Offset: 0x000457F8
		[Token(Token = "0x600C281")]
		[Address(RVA = "0x33FC050", Offset = "0x33FAC50", VA = "0x1833FC050")]
		private bool _ExecuteShowItem(Command command)
		{
			return default(bool);
		}

		// Token: 0x0600C282 RID: 49794 RVA: 0x00047610 File Offset: 0x00045810
		[Token(Token = "0x600C282")]
		[Address(RVA = "0x33FBF20", Offset = "0x33FAB20", VA = "0x1833FBF20")]
		private bool _ExecuteHideItem(Command command)
		{
			return default(bool);
		}

		// Token: 0x0600C283 RID: 49795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C283")]
		[Address(RVA = "0x33FBCA0", Offset = "0x33FA8A0", VA = "0x1833FBCA0", Slot = "12")]
		protected override void ForceCommandEnd()
		{
		}

		// Token: 0x0600C284 RID: 49796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C284")]
		[Address(RVA = "0x33FC4C0", Offset = "0x33FB0C0", VA = "0x1833FC4C0")]
		private void _ShowItem(Command command)
		{
		}

		// Token: 0x0600C285 RID: 49797 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C285")]
		[Address(RVA = "0x33FC1D0", Offset = "0x33FADD0", VA = "0x1833FC1D0")]
		private AVGShowItemPanel.SlotStyle _FindSlotStyle(string style)
		{
			return null;
		}

		// Token: 0x0600C286 RID: 49798 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C286")]
		[Address(RVA = "0x33FC330", Offset = "0x33FAF30", VA = "0x1833FC330")]
		private Sprite _LoadSprite(string key)
		{
			return null;
		}

		// Token: 0x0600C287 RID: 49799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C287")]
		[Address(RVA = "0x33FC3E0", Offset = "0x33FAFE0", VA = "0x1833FC3E0")]
		private void _Reset()
		{
		}

		// Token: 0x0600C288 RID: 49800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C288")]
		[Address(RVA = "0x33FC8E0", Offset = "0x33FB4E0", VA = "0x1833FC8E0")]
		public AVGShowItemPanel()
		{
		}

		// Token: 0x0600C28A RID: 49802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C28A")]
		[Address(RVA = "0x1C5FCF0", Offset = "0x1C5E8F0", VA = "0x181C5FCF0")]
		private void <>xLuaBaseProxy_OnReset()
		{
		}

		// Token: 0x0400C45A RID: 50266
		[Token(Token = "0x400C45A")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private AVGShowItemPanel.SlotStyle[] _slotStyles;

		// Token: 0x0400C45B RID: 50267
		[Token(Token = "0x400C45B")]
		[FieldOffset(Offset = "0x58")]
		private AVGShowItemSlot _slotInUse;

		// Token: 0x0400C45C RID: 50268
		[Token(Token = "0x400C45C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetExecutors;

		// Token: 0x0400C45D RID: 50269
		[Token(Token = "0x400C45D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnReset;

		// Token: 0x0400C45E RID: 50270
		[Token(Token = "0x400C45E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_DontInvoke_PlzImplInternalResRefCollector;

		// Token: 0x0400C45F RID: 50271
		[Token(Token = "0x400C45F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__ExecuteShowItem;

		// Token: 0x0400C460 RID: 50272
		[Token(Token = "0x400C460")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__ExecuteHideItem;

		// Token: 0x0400C461 RID: 50273
		[Token(Token = "0x400C461")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_ForceCommandEnd;

		// Token: 0x0400C462 RID: 50274
		[Token(Token = "0x400C462")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__ShowItem;

		// Token: 0x0400C463 RID: 50275
		[Token(Token = "0x400C463")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__FindSlotStyle;

		// Token: 0x0400C464 RID: 50276
		[Token(Token = "0x400C464")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__LoadSprite;

		// Token: 0x0400C465 RID: 50277
		[Token(Token = "0x400C465")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__Reset;

		// Token: 0x0400C466 RID: 50278
		[Token(Token = "0x400C466")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001EAD RID: 7853
		[Token(Token = "0x2001EAD")]
		private class InternalResRefCollector : AbstractResRefCollecter
		{
			// Token: 0x0600C28B RID: 49803 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C28B")]
			[Address(RVA = "0x3404600", Offset = "0x3403200", VA = "0x183404600", Slot = "4")]
			public override void GatherResRefs(Command command, HashSet<string> references)
			{
			}

			// Token: 0x0600C28C RID: 49804 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C28C")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			public InternalResRefCollector()
			{
			}
		}

		// Token: 0x02001EAE RID: 7854
		[Token(Token = "0x2001EAE")]
		[Serializable]
		private class SlotStyle
		{
			// Token: 0x0600C28D RID: 49805 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C28D")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public SlotStyle()
			{
			}

			// Token: 0x0400C467 RID: 50279
			[Token(Token = "0x400C467")]
			[FieldOffset(Offset = "0x10")]
			public string styleKey;

			// Token: 0x0400C468 RID: 50280
			[Token(Token = "0x400C468")]
			[FieldOffset(Offset = "0x18")]
			public UnityEngine.Object slotPrefab;
		}
	}
}
