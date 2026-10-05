using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL04.Node
{
	// Token: 0x02005727 RID: 22311
	[Token(Token = "0x2005727")]
	public class RL04DungeonNodeViewLogic : RoguelikeDungeonNodeDefaultLogic
	{
		// Token: 0x17004CAE RID: 19630
		// (get) Token: 0x06020B34 RID: 133940 RVA: 0x000B6DD8 File Offset: 0x000B4FD8
		[Token(Token = "0x17004CAE")]
		private bool m_isAmiyaSpecialNode
		{
			[Token(Token = "0x6020B34")]
			[Address(RVA = "0x1B129C0", Offset = "0x1B115C0", VA = "0x181B129C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06020B35 RID: 133941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020B35")]
		[Address(RVA = "0x1B0F7A0", Offset = "0x1B0E3A0", VA = "0x181B0F7A0", Slot = "4")]
		public override void RenderBossWidgets()
		{
		}

		// Token: 0x06020B36 RID: 133942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020B36")]
		[Address(RVA = "0x1B11480", Offset = "0x1B10080", VA = "0x181B11480", Slot = "5")]
		public override void RenderNonBossWidigets()
		{
		}

		// Token: 0x06020B37 RID: 133943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020B37")]
		[Address(RVA = "0x1B124B0", Offset = "0x1B110B0", VA = "0x181B124B0", Slot = "7")]
		public override void RenderOtherWidgets()
		{
		}

		// Token: 0x06020B38 RID: 133944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020B38")]
		[Address(RVA = "0x1B0FD80", Offset = "0x1B0E980", VA = "0x181B0FD80", Slot = "6")]
		public override void RenderCurves()
		{
		}

		// Token: 0x06020B39 RID: 133945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020B39")]
		[Address(RVA = "0x1B126B0", Offset = "0x1B112B0", VA = "0x181B126B0")]
		private void _RenderNodeUpdate()
		{
		}

		// Token: 0x06020B3A RID: 133946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020B3A")]
		[Address(RVA = "0x1B125A0", Offset = "0x1B111A0", VA = "0x181B125A0")]
		private void _RenderAmiyaZoneNode()
		{
		}

		// Token: 0x06020B3B RID: 133947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020B3B")]
		[Address(RVA = "0x1B0F340", Offset = "0x1B0DF40", VA = "0x181B0F340")]
		public void OnLvlupedClick()
		{
		}

		// Token: 0x06020B3C RID: 133948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020B3C")]
		[Address(RVA = "0x1B12940", Offset = "0x1B11540", VA = "0x181B12940")]
		public RL04DungeonNodeViewLogic()
		{
		}

		// Token: 0x06020B3D RID: 133949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020B3D")]
		[Address(RVA = "0x1A77EA0", Offset = "0x1A76AA0", VA = "0x181A77EA0")]
		private void <>xLuaBaseProxy_RenderBossWidgets()
		{
		}

		// Token: 0x06020B3E RID: 133950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020B3E")]
		[Address(RVA = "0x1A77EC0", Offset = "0x1A76AC0", VA = "0x181A77EC0")]
		private void <>xLuaBaseProxy_RenderNonBossWidigets()
		{
		}

		// Token: 0x06020B3F RID: 133951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020B3F")]
		[Address(RVA = "0x1A77ED0", Offset = "0x1A76AD0", VA = "0x181A77ED0")]
		private void <>xLuaBaseProxy_RenderOtherWidgets()
		{
		}

		// Token: 0x06020B40 RID: 133952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020B40")]
		[Address(RVA = "0x1A77EB0", Offset = "0x1A76AB0", VA = "0x181A77EB0")]
		private void <>xLuaBaseProxy_RenderCurves()
		{
		}

		// Token: 0x0402C621 RID: 181793
		[Token(Token = "0x402C621")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _unactiveImg;

		// Token: 0x0402C622 RID: 181794
		[Token(Token = "0x402C622")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _mask;

		// Token: 0x0402C623 RID: 181795
		[Token(Token = "0x402C623")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _bossEffect;

		// Token: 0x0402C624 RID: 181796
		[Token(Token = "0x402C624")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _finalBossEffect;

		// Token: 0x0402C625 RID: 181797
		[Token(Token = "0x402C625")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _panelNodeUpgrade;

		// Token: 0x0402C626 RID: 181798
		[Token(Token = "0x402C626")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _lvluped;

		// Token: 0x0402C627 RID: 181799
		[Token(Token = "0x402C627")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _ableToLvlup;

		// Token: 0x0402C628 RID: 181800
		[Token(Token = "0x402C628")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _lvlupedHotspot;

		// Token: 0x0402C629 RID: 181801
		[Token(Token = "0x402C629")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private RoguelikeDetailNodeDialog _detailDialogPrefab;

		// Token: 0x0402C62A RID: 181802
		[Token(Token = "0x402C62A")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _normalGroupObj;

		// Token: 0x0402C62B RID: 181803
		[Token(Token = "0x402C62B")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _verCountNum;

		// Token: 0x0402C62C RID: 181804
		[Token(Token = "0x402C62C")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("amiya blur")]
		private GameObject _amiyaBlurObj;

		// Token: 0x0402C62D RID: 181805
		[Token(Token = "0x402C62D")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("amiya blur")]
		private Color _amiyaWidgetColor;

		// Token: 0x0402C62E RID: 181806
		[Token(Token = "0x402C62E")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("amiya blur")]
		private Color _amiyaReflectColor;

		// Token: 0x0402C62F RID: 181807
		[Token(Token = "0x402C62F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_m_isAmiyaSpecialNode;

		// Token: 0x0402C630 RID: 181808
		[Token(Token = "0x402C630")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RenderBossWidgets;

		// Token: 0x0402C631 RID: 181809
		[Token(Token = "0x402C631")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RenderNonBossWidigets;

		// Token: 0x0402C632 RID: 181810
		[Token(Token = "0x402C632")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RenderOtherWidgets;

		// Token: 0x0402C633 RID: 181811
		[Token(Token = "0x402C633")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_RenderCurves;

		// Token: 0x0402C634 RID: 181812
		[Token(Token = "0x402C634")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RenderNodeUpdate;

		// Token: 0x0402C635 RID: 181813
		[Token(Token = "0x402C635")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__RenderAmiyaZoneNode;

		// Token: 0x0402C636 RID: 181814
		[Token(Token = "0x402C636")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnLvlupedClick;

		// Token: 0x0402C637 RID: 181815
		[Token(Token = "0x402C637")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
