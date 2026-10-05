using System;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004343 RID: 17219
	[Token(Token = "0x2004343")]
	public class SandboxV2LogisticsTotalBuffInfoView : DataBinder<SandboxV2LogisticsHomeProperty>
	{
		// Token: 0x0601A719 RID: 108313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A719")]
		[Address(RVA = "0x138CB20", Offset = "0x138B720", VA = "0x18138CB20", Slot = "7")]
		public override void OnValueChanged(SandboxV2LogisticsHomeProperty property)
		{
		}

		// Token: 0x0601A71A RID: 108314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A71A")]
		[Address(RVA = "0x138CFF0", Offset = "0x138BBF0", VA = "0x18138CFF0")]
		private void _InitIfNot(bool isShow)
		{
		}

		// Token: 0x0601A71B RID: 108315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A71B")]
		[Address(RVA = "0x138D1B0", Offset = "0x138BDB0", VA = "0x18138D1B0")]
		public SandboxV2LogisticsTotalBuffInfoView()
		{
		}

		// Token: 0x040219D4 RID: 137684
		[Token(Token = "0x40219D4")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("Buff Status")]
		private GameObject _panelInvalid;

		// Token: 0x040219D5 RID: 137685
		[Token(Token = "0x40219D5")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Buff Status")]
		private GameObject _panelInvalidNoChar;

		// Token: 0x040219D6 RID: 137686
		[Token(Token = "0x40219D6")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Buff Status")]
		private GameObject _panelInvalidNoDrink;

		// Token: 0x040219D7 RID: 137687
		[Token(Token = "0x40219D7")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Buff Status")]
		private GameObject _panelInvalidInRift;

		// Token: 0x040219D8 RID: 137688
		[Token(Token = "0x40219D8")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Buff Status")]
		private Text _textInvalidDesc;

		// Token: 0x040219D9 RID: 137689
		[Token(Token = "0x40219D9")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _textPopulation;

		// Token: 0x040219DA RID: 137690
		[Token(Token = "0x40219DA")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _textDrink;

		// Token: 0x040219DB RID: 137691
		[Token(Token = "0x40219DB")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _panelDrinkBtnNormal;

		// Token: 0x040219DC RID: 137692
		[Token(Token = "0x40219DC")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _panelDrinkBtnNotEnough;

		// Token: 0x040219DD RID: 137693
		[Token(Token = "0x40219DD")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _textHoldDrink;

		// Token: 0x040219DE RID: 137694
		[Token(Token = "0x40219DE")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private SimpleLayoutContent _buffLayoutContent;

		// Token: 0x040219DF RID: 137695
		[Token(Token = "0x40219DF")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x040219E0 RID: 137696
		[Token(Token = "0x40219E0")]
		[FieldOffset(Offset = "0x80")]
		private bool m_isInited;

		// Token: 0x040219E1 RID: 137697
		[Token(Token = "0x40219E1")]
		[FieldOffset(Offset = "0x88")]
		private SandboxV2LogisticsTotalBuffInfoView.BuffListAdapter m_buffListAdapter;

		// Token: 0x040219E2 RID: 137698
		[Token(Token = "0x40219E2")]
		[FieldOffset(Offset = "0x90")]
		private SandboxV2LogisticsHomeViewModel m_viewModel;

		// Token: 0x040219E3 RID: 137699
		[Token(Token = "0x40219E3")]
		[FieldOffset(Offset = "0x98")]
		private FadeSwitchTween m_fadeSwitchTween;

		// Token: 0x040219E4 RID: 137700
		[Token(Token = "0x40219E4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x040219E5 RID: 137701
		[Token(Token = "0x40219E5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040219E6 RID: 137702
		[Token(Token = "0x40219E6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004344 RID: 17220
		[Token(Token = "0x2004344")]
		public class BuffListAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0601A71C RID: 108316 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601A71C")]
			[Address(RVA = "0x13840D0", Offset = "0x1382CD0", VA = "0x1813840D0")]
			public BuffListAdapter(SandboxV2LogisticsTotalBuffInfoView closure)
			{
			}

			// Token: 0x17003EBD RID: 16061
			// (get) Token: 0x0601A71D RID: 108317 RVA: 0x000A1CA0 File Offset: 0x0009FEA0
			[Token(Token = "0x17003EBD")]
			public override int count
			{
				[Token(Token = "0x601A71D")]
				[Address(RVA = "0x1384150", Offset = "0x1382D50", VA = "0x181384150", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601A71E RID: 108318 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601A71E")]
			[Address(RVA = "0x1383F00", Offset = "0x1382B00", VA = "0x181383F00", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x040219E7 RID: 137703
			[Token(Token = "0x40219E7")]
			[FieldOffset(Offset = "0x20")]
			private SandboxV2LogisticsTotalBuffInfoView m_closure;

			// Token: 0x040219E8 RID: 137704
			[Token(Token = "0x40219E8")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x040219E9 RID: 137705
			[Token(Token = "0x40219E9")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x040219EA RID: 137706
			[Token(Token = "0x40219EA")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
