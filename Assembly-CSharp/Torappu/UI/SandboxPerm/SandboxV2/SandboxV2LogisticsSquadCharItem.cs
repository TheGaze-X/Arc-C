using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200433F RID: 17215
	[Token(Token = "0x200433F")]
	public class SandboxV2LogisticsSquadCharItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601A70F RID: 108303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A70F")]
		[Address(RVA = "0x138C350", Offset = "0x138AF50", VA = "0x18138C350")]
		public void Render(SandboxV2LogisticsSquadCharItem.RenderParam param)
		{
		}

		// Token: 0x0601A710 RID: 108304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A710")]
		[Address(RVA = "0x138C260", Offset = "0x138AE60", VA = "0x18138C260")]
		public void OnItemClicked()
		{
		}

		// Token: 0x0601A711 RID: 108305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A711")]
		[Address(RVA = "0x138C1C0", Offset = "0x138ADC0", VA = "0x18138C1C0")]
		public void OnBlockItemClicked()
		{
		}

		// Token: 0x0601A712 RID: 108306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A712")]
		[Address(RVA = "0x138C620", Offset = "0x138B220", VA = "0x18138C620")]
		public SandboxV2LogisticsSquadCharItem()
		{
		}

		// Token: 0x040219B0 RID: 137648
		[Token(Token = "0x40219B0")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _imgChar;

		// Token: 0x040219B1 RID: 137649
		[Token(Token = "0x40219B1")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _imgProfession;

		// Token: 0x040219B2 RID: 137650
		[Token(Token = "0x40219B2")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SandboxV2LogisticsCharBeanView _charBeanView;

		// Token: 0x040219B3 RID: 137651
		[Token(Token = "0x40219B3")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelSelected;

		// Token: 0x040219B4 RID: 137652
		[Token(Token = "0x40219B4")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelBlock;

		// Token: 0x040219B5 RID: 137653
		[Token(Token = "0x40219B5")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _panelEmpty;

		// Token: 0x040219B6 RID: 137654
		[Token(Token = "0x40219B6")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _panelChar;

		// Token: 0x040219B7 RID: 137655
		[Token(Token = "0x40219B7")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private CanvasGroup _canvasGroupEmpty;

		// Token: 0x040219B8 RID: 137656
		[Token(Token = "0x40219B8")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float _alphaNormal;

		// Token: 0x040219B9 RID: 137657
		[Token(Token = "0x40219B9")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private float _alphaInactive;

		// Token: 0x040219BA RID: 137658
		[Token(Token = "0x40219BA")]
		[FieldOffset(Offset = "0x60")]
		private UIStateFinder m_stateFinder;

		// Token: 0x040219BB RID: 137659
		[Token(Token = "0x40219BB")]
		[FieldOffset(Offset = "0x70")]
		private bool m_isInited;

		// Token: 0x040219BC RID: 137660
		[Token(Token = "0x40219BC")]
		[FieldOffset(Offset = "0x74")]
		private int m_cachedIndex;

		// Token: 0x040219BD RID: 137661
		[Token(Token = "0x40219BD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040219BE RID: 137662
		[Token(Token = "0x40219BE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnItemClicked;

		// Token: 0x040219BF RID: 137663
		[Token(Token = "0x40219BF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnBlockItemClicked;

		// Token: 0x040219C0 RID: 137664
		[Token(Token = "0x40219C0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004340 RID: 17216
		[Token(Token = "0x2004340")]
		public struct RenderParam
		{
			// Token: 0x040219C1 RID: 137665
			[Token(Token = "0x40219C1")]
			[FieldOffset(Offset = "0x0")]
			public SandboxV2LogisticsCharViewModel charViewModel;

			// Token: 0x040219C2 RID: 137666
			[Token(Token = "0x40219C2")]
			[FieldOffset(Offset = "0x8")]
			public int index;

			// Token: 0x040219C3 RID: 137667
			[Token(Token = "0x40219C3")]
			[FieldOffset(Offset = "0xC")]
			public bool isValid;

			// Token: 0x040219C4 RID: 137668
			[Token(Token = "0x40219C4")]
			[FieldOffset(Offset = "0xD")]
			public bool isSelected;

			// Token: 0x040219C5 RID: 137669
			[Token(Token = "0x40219C5")]
			[FieldOffset(Offset = "0xE")]
			public bool isEmptyNeedAlpha;
		}
	}
}
