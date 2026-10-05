using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.VoucherSkin
{
	// Token: 0x02003B8D RID: 15245
	[Token(Token = "0x2003B8D")]
	public class VoucherSkinHomeView : DataBinder<VoucherSkinHomeViewProperty>
	{
		// Token: 0x06017E46 RID: 97862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017E46")]
		[Address(RVA = "0x1025D70", Offset = "0x1024970", VA = "0x181025D70", Slot = "7")]
		public override void OnValueChanged(VoucherSkinHomeViewProperty property)
		{
		}

		// Token: 0x06017E47 RID: 97863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017E47")]
		[Address(RVA = "0x1026110", Offset = "0x1024D10", VA = "0x181026110")]
		private void _InitIfNot(ItemType voucherItemType)
		{
		}

		// Token: 0x06017E48 RID: 97864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017E48")]
		[Address(RVA = "0x1025CE0", Offset = "0x10248E0", VA = "0x181025CE0")]
		public void OnClickExit()
		{
		}

		// Token: 0x06017E49 RID: 97865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017E49")]
		[Address(RVA = "0x1025C10", Offset = "0x1024810", VA = "0x181025C10")]
		public void OnClickCloseRule()
		{
		}

		// Token: 0x06017E4A RID: 97866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017E4A")]
		[Address(RVA = "0x1026310", Offset = "0x1024F10", VA = "0x181026310")]
		public VoucherSkinHomeView()
		{
		}

		// Token: 0x0401CE1B RID: 118299
		[Token(Token = "0x401CE1B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _titleText;

		// Token: 0x0401CE1C RID: 118300
		[Token(Token = "0x401CE1C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _emptyText;

		// Token: 0x0401CE1D RID: 118301
		[Token(Token = "0x401CE1D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _skinListPanel;

		// Token: 0x0401CE1E RID: 118302
		[Token(Token = "0x401CE1E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _emptyPanel;

		// Token: 0x0401CE1F RID: 118303
		[Token(Token = "0x401CE1F")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private VoucherSkinLoopAdapter _loopAdapter;

		// Token: 0x0401CE20 RID: 118304
		[Token(Token = "0x401CE20")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private List<VoucherSkinBasePlugin> _pluginPrefabs;

		// Token: 0x0401CE21 RID: 118305
		[Token(Token = "0x401CE21")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private RectTransform _pluginContainer;

		// Token: 0x0401CE22 RID: 118306
		[Token(Token = "0x401CE22")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UIAnimationLocation _spreadAnimLocation;

		// Token: 0x0401CE23 RID: 118307
		[Token(Token = "0x401CE23")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _ruleTitle;

		// Token: 0x0401CE24 RID: 118308
		[Token(Token = "0x401CE24")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _ruleDesc;

		// Token: 0x0401CE25 RID: 118309
		[Token(Token = "0x401CE25")]
		[FieldOffset(Offset = "0x78")]
		private AnimationSwitchTween m_spreadSwitchTween;

		// Token: 0x0401CE26 RID: 118310
		[Token(Token = "0x401CE26")]
		[FieldOffset(Offset = "0x80")]
		private VoucherSkinBasePlugin m_plugin;

		// Token: 0x0401CE27 RID: 118311
		[Token(Token = "0x401CE27")]
		[FieldOffset(Offset = "0x88")]
		private bool m_isInited;

		// Token: 0x0401CE28 RID: 118312
		[Token(Token = "0x401CE28")]
		[FieldOffset(Offset = "0x90")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0401CE29 RID: 118313
		[Token(Token = "0x401CE29")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0401CE2A RID: 118314
		[Token(Token = "0x401CE2A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401CE2B RID: 118315
		[Token(Token = "0x401CE2B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnClickExit;

		// Token: 0x0401CE2C RID: 118316
		[Token(Token = "0x401CE2C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnClickCloseRule;

		// Token: 0x0401CE2D RID: 118317
		[Token(Token = "0x401CE2D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
