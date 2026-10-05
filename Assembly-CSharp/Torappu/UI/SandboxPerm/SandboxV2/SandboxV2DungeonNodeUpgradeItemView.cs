using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004268 RID: 17000
	[Token(Token = "0x2004268")]
	public class SandboxV2DungeonNodeUpgradeItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17003E39 RID: 15929
		// (get) Token: 0x0601A335 RID: 107317 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601A336 RID: 107318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003E39")]
		public ILoadAsset assetLoader
		{
			[Token(Token = "0x601A335")]
			[Address(RVA = "0x131AAB0", Offset = "0x13196B0", VA = "0x18131AAB0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601A336")]
			[Address(RVA = "0x131AB70", Offset = "0x1319770", VA = "0x18131AB70")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17003E3A RID: 15930
		// (get) Token: 0x0601A337 RID: 107319 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601A338 RID: 107320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003E3A")]
		public Action workbenchEvent
		{
			[Token(Token = "0x601A337")]
			[Address(RVA = "0x131AB10", Offset = "0x1319710", VA = "0x18131AB10")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601A338")]
			[Address(RVA = "0x131ABF0", Offset = "0x13197F0", VA = "0x18131ABF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601A339 RID: 107321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A339")]
		[Address(RVA = "0x131A100", Offset = "0x1318D00", VA = "0x18131A100")]
		public void OnWorkbenchEvent()
		{
		}

		// Token: 0x0601A33A RID: 107322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A33A")]
		[Address(RVA = "0x131A210", Offset = "0x1318E10", VA = "0x18131A210")]
		public void Render(SandboxV2DungeonNodeUpgradeItemViewModel itemModel)
		{
		}

		// Token: 0x0601A33B RID: 107323 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A33B")]
		[Address(RVA = "0x131A9F0", Offset = "0x13195F0", VA = "0x18131A9F0")]
		public GameObject TutorialOnly_GetTutorialGo()
		{
			return null;
		}

		// Token: 0x0601A33C RID: 107324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A33C")]
		[Address(RVA = "0x131AA50", Offset = "0x1319650", VA = "0x18131AA50")]
		public SandboxV2DungeonNodeUpgradeItemView()
		{
		}

		// Token: 0x0402122C RID: 135724
		[Token(Token = "0x402122C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _iconImage;

		// Token: 0x0402122D RID: 135725
		[Token(Token = "0x402122D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Color _iconActiveColor;

		// Token: 0x0402122E RID: 135726
		[Token(Token = "0x402122E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Color _iconInactiveColor;

		// Token: 0x0402122F RID: 135727
		[Token(Token = "0x402122F")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIAtlasImage _iconBackImage;

		// Token: 0x04021230 RID: 135728
		[Token(Token = "0x4021230")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Color _iconBackActiveColor;

		// Token: 0x04021231 RID: 135729
		[Token(Token = "0x4021231")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Color _iconBackInactiveColor;

		// Token: 0x04021232 RID: 135730
		[Token(Token = "0x4021232")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _nameText;

		// Token: 0x04021233 RID: 135731
		[Token(Token = "0x4021233")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _unlockDescText;

		// Token: 0x04021234 RID: 135732
		[Token(Token = "0x4021234")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Color _unlockDescActiveColor;

		// Token: 0x04021235 RID: 135733
		[Token(Token = "0x4021235")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Color _unlockDescInactiveColor;

		// Token: 0x04021236 RID: 135734
		[Token(Token = "0x4021236")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Text _unlockEffectText;

		// Token: 0x04021237 RID: 135735
		[Token(Token = "0x4021237")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Color _unlockEffectActiveColor;

		// Token: 0x04021238 RID: 135736
		[Token(Token = "0x4021238")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private Color _unlockEffectInactiveColor;

		// Token: 0x04021239 RID: 135737
		[Token(Token = "0x4021239")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private UIAtlasImage[] _headImages;

		// Token: 0x0402123A RID: 135738
		[Token(Token = "0x402123A")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private Color _headImageActiveColor;

		// Token: 0x0402123B RID: 135739
		[Token(Token = "0x402123B")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private Color _headImageInactiveColor;

		// Token: 0x0402123C RID: 135740
		[Token(Token = "0x402123C")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private Text[] _headTexts;

		// Token: 0x0402123D RID: 135741
		[Token(Token = "0x402123D")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private Color _headTextActiveColor;

		// Token: 0x0402123E RID: 135742
		[Token(Token = "0x402123E")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private Color _headTextInactiveColor;

		// Token: 0x0402123F RID: 135743
		[Token(Token = "0x402123F")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		private GameObject[] _activePanels;

		// Token: 0x04021240 RID: 135744
		[Token(Token = "0x4021240")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		private GameObject _inactivePanel;

		// Token: 0x04021241 RID: 135745
		[Token(Token = "0x4021241")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		private GameObject _unlockTipsPanel;

		// Token: 0x04021242 RID: 135746
		[Token(Token = "0x4021242")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		private Text _unlockTipsText;

		// Token: 0x04021243 RID: 135747
		[Token(Token = "0x4021243")]
		[FieldOffset(Offset = "0x130")]
		[SerializeField]
		private GameObject _bkg;

		// Token: 0x04021244 RID: 135748
		[Token(Token = "0x4021244")]
		[FieldOffset(Offset = "0x138")]
		[SerializeField]
		private ScrollRect _contentScrollRect;

		// Token: 0x04021245 RID: 135749
		[Token(Token = "0x4021245")]
		[FieldOffset(Offset = "0x140")]
		private string m_cachedUpdateId;

		// Token: 0x04021248 RID: 135752
		[Token(Token = "0x4021248")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_assetLoader;

		// Token: 0x04021249 RID: 135753
		[Token(Token = "0x4021249")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_assetLoader;

		// Token: 0x0402124A RID: 135754
		[Token(Token = "0x402124A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_workbenchEvent;

		// Token: 0x0402124B RID: 135755
		[Token(Token = "0x402124B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_workbenchEvent;

		// Token: 0x0402124C RID: 135756
		[Token(Token = "0x402124C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnWorkbenchEvent;

		// Token: 0x0402124D RID: 135757
		[Token(Token = "0x402124D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402124E RID: 135758
		[Token(Token = "0x402124E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_TutorialOnly_GetTutorialGo;

		// Token: 0x0402124F RID: 135759
		[Token(Token = "0x402124F")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
