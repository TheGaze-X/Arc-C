using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x0200679F RID: 26527
	[Token(Token = "0x200679F")]
	public class StageZoneHomeActivityEntry : StageZoneHomeEntryItemPlugin
	{
		// Token: 0x060260AE RID: 155822 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60260AE")]
		[Address(RVA = "0x211E140", Offset = "0x211CD40", VA = "0x18211E140", Slot = "7")]
		protected override Sprite GetFuncIcon()
		{
			return null;
		}

		// Token: 0x060260AF RID: 155823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60260AF")]
		[Address(RVA = "0x211E210", Offset = "0x211CE10", VA = "0x18211E210", Slot = "5")]
		protected override void OnDataUpdated()
		{
		}

		// Token: 0x060260B0 RID: 155824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60260B0")]
		[Address(RVA = "0x211E560", Offset = "0x211D160", VA = "0x18211E560")]
		private void _LoadActivityEntryResIfNeeded()
		{
		}

		// Token: 0x060260B1 RID: 155825 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60260B1")]
		[Address(RVA = "0x211E820", Offset = "0x211D420", VA = "0x18211E820")]
		private void _UpdateItemCount()
		{
		}

		// Token: 0x060260B2 RID: 155826 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60260B2")]
		[Address(RVA = "0x211E9E0", Offset = "0x211D5E0", VA = "0x18211E9E0")]
		private void _UpdateStageInfo()
		{
		}

		// Token: 0x060260B3 RID: 155827 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60260B3")]
		[Address(RVA = "0x211EB80", Offset = "0x211D780", VA = "0x18211EB80")]
		public StageZoneHomeActivityEntry()
		{
		}

		// Token: 0x04035897 RID: 219287
		[Token(Token = "0x4035897")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelItem;

		// Token: 0x04035898 RID: 219288
		[Token(Token = "0x4035898")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textItemCount;

		// Token: 0x04035899 RID: 219289
		[Token(Token = "0x4035899")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _imgItemIcon;

		// Token: 0x0403589A RID: 219290
		[Token(Token = "0x403589A")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _panelStageLocked;

		// Token: 0x0403589B RID: 219291
		[Token(Token = "0x403589B")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("FuncIcon")]
		private Sprite _iconSideStory;

		// Token: 0x0403589C RID: 219292
		[Token(Token = "0x403589C")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("FuncIcon")]
		private Sprite _iconBranchline;

		// Token: 0x0403589D RID: 219293
		[Token(Token = "0x403589D")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("FuncIcon")]
		private Sprite _iconMiniStory;

		// Token: 0x0403589E RID: 219294
		[Token(Token = "0x403589E")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("FuncIcon")]
		private Sprite _iconDefault;

		// Token: 0x0403589F RID: 219295
		[Token(Token = "0x403589F")]
		[FieldOffset(Offset = "0x70")]
		private ZoneHomeEntryActivityModel m_viewModel;

		// Token: 0x040358A0 RID: 219296
		[Token(Token = "0x40358A0")]
		[FieldOffset(Offset = "0x78")]
		private string m_checkDirtyActId;

		// Token: 0x040358A1 RID: 219297
		[Token(Token = "0x40358A1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetFuncIcon;

		// Token: 0x040358A2 RID: 219298
		[Token(Token = "0x40358A2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnDataUpdated;

		// Token: 0x040358A3 RID: 219299
		[Token(Token = "0x40358A3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__LoadActivityEntryResIfNeeded;

		// Token: 0x040358A4 RID: 219300
		[Token(Token = "0x40358A4")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__UpdateItemCount;

		// Token: 0x040358A5 RID: 219301
		[Token(Token = "0x40358A5")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__UpdateStageInfo;

		// Token: 0x040358A6 RID: 219302
		[Token(Token = "0x40358A6")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
