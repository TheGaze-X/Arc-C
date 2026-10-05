using System;
using System.Runtime.CompilerServices;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005C53 RID: 23635
	[Token(Token = "0x2005C53")]
	public class ClimbTowerEntryTowerView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17005063 RID: 20579
		// (get) Token: 0x060223FB RID: 140283 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060223FC RID: 140284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005063")]
		public Action<ClimbTowerTowerType, string> onTowerClicked
		{
			[Token(Token = "0x60223FB")]
			[Address(RVA = "0x1CA8BD0", Offset = "0x1CA77D0", VA = "0x181CA8BD0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x60223FC")]
			[Address(RVA = "0x1CA8C90", Offset = "0x1CA7890", VA = "0x181CA8C90")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17005064 RID: 20580
		// (get) Token: 0x060223FD RID: 140285 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060223FE RID: 140286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005064")]
		public UIPage page
		{
			[Token(Token = "0x60223FD")]
			[Address(RVA = "0x1CA8C30", Offset = "0x1CA7830", VA = "0x181CA8C30")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x60223FE")]
			[Address(RVA = "0x1CA8D10", Offset = "0x1CA7910", VA = "0x181CA8D10")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060223FF RID: 140287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60223FF")]
		[Address(RVA = "0x1CA80A0", Offset = "0x1CA6CA0", VA = "0x181CA80A0")]
		public void Render(ClimbTowerEntryMapTowerModel model, Vector2 size, int position)
		{
		}

		// Token: 0x06022400 RID: 140288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022400")]
		[Address(RVA = "0x1CA7F90", Offset = "0x1CA6B90", VA = "0x181CA7F90")]
		public void EventOnTowerClicked()
		{
		}

		// Token: 0x06022401 RID: 140289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022401")]
		[Address(RVA = "0x1CA82A0", Offset = "0x1CA6EA0", VA = "0x181CA82A0")]
		private void _RenderTowerButton(ClimbTowerEntryMapTowerModel model, int position)
		{
		}

		// Token: 0x06022402 RID: 140290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022402")]
		[Address(RVA = "0x1CA8AA0", Offset = "0x1CA76A0", VA = "0x181CA8AA0")]
		private void _RenderTrainEntryButton(ClimbTowerEntryMapTowerModel model)
		{
		}

		// Token: 0x06022403 RID: 140291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022403")]
		[Address(RVA = "0x1CA8B70", Offset = "0x1CA7770", VA = "0x181CA8B70")]
		public ClimbTowerEntryTowerView()
		{
		}

		// Token: 0x0402F01B RID: 192539
		[Token(Token = "0x402F01B")]
		private const string FLOOR_TARGET_FORMAT = "/{0}";

		// Token: 0x0402F01C RID: 192540
		[Token(Token = "0x402F01C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Group("Position config")]
		private Vector2 _normalUpPos;

		// Token: 0x0402F01D RID: 192541
		[Token(Token = "0x402F01D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("Position config")]
		private Vector2 _normalDownPos;

		// Token: 0x0402F01E RID: 192542
		[Token(Token = "0x402F01E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _rectNormalTower;

		// Token: 0x0402F01F RID: 192543
		[Token(Token = "0x402F01F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private LayoutElement _layoutElement;

		// Token: 0x0402F020 RID: 192544
		[Token(Token = "0x402F020")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Train")]
		private GameObject _panelTrain;

		// Token: 0x0402F021 RID: 192545
		[Token(Token = "0x402F021")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Train")]
		private GameObject _trainInBattle;

		// Token: 0x0402F022 RID: 192546
		[Token(Token = "0x402F022")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Normal")]
		private GameObject _panelTower;

		// Token: 0x0402F023 RID: 192547
		[Token(Token = "0x402F023")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Normal")]
		private Image _stageIcon;

		// Token: 0x0402F024 RID: 192548
		[Token(Token = "0x402F024")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Normal")]
		private Image _towerIcon;

		// Token: 0x0402F025 RID: 192549
		[Token(Token = "0x402F025")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Normal")]
		private GameObject _panelTrackPoint;

		// Token: 0x0402F026 RID: 192550
		[Token(Token = "0x402F026")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Normal")]
		private GameObject _replicatedBg;

		// Token: 0x0402F027 RID: 192551
		[Token(Token = "0x402F027")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("Normal")]
		private GameObject _replicatedNotCheckedTips;

		// Token: 0x0402F028 RID: 192552
		[Token(Token = "0x402F028")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("InBattle")]
		private TwoStateToggle _toggleInBattle;

		// Token: 0x0402F029 RID: 192553
		[Token(Token = "0x402F029")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("InBattle")]
		private TwoStateToggle[] _toggleInBattleHard;

		// Token: 0x0402F02A RID: 192554
		[Token(Token = "0x402F02A")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("Label")]
		private Text[] _textTowerName;

		// Token: 0x0402F02B RID: 192555
		[Token(Token = "0x402F02B")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("Label")]
		private Text _textTowerSubname;

		// Token: 0x0402F02C RID: 192556
		[Token(Token = "0x402F02C")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Group("Label")]
		private ClimbTowerEntryTowerProgressView[] _progressView;

		// Token: 0x0402F02D RID: 192557
		[Token(Token = "0x402F02D")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[Group("Progress")]
		private TwoStateToggle _toggleProgress;

		// Token: 0x0402F02E RID: 192558
		[Token(Token = "0x402F02E")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[Group("Progress")]
		private TwoStateToggle _toggleProgressComplete;

		// Token: 0x0402F02F RID: 192559
		[Token(Token = "0x402F02F")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[Group("Progress")]
		private Text _textFloorCurr;

		// Token: 0x0402F030 RID: 192560
		[Token(Token = "0x402F030")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[Group("Progress")]
		private Text _textFloorTarget;

		// Token: 0x0402F031 RID: 192561
		[Token(Token = "0x402F031")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[Group("Progress")]
		private GameObject _panelProgress;

		// Token: 0x0402F032 RID: 192562
		[Token(Token = "0x402F032")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		[Group("BattleInfo")]
		private Image _godCardImage;

		// Token: 0x0402F033 RID: 192563
		[Token(Token = "0x402F033")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		[Group("BattleInfo")]
		private Text _textTrapCount;

		// Token: 0x0402F034 RID: 192564
		[Token(Token = "0x402F034")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		[Group("BattleInfo")]
		private Text _textCharCount;

		// Token: 0x0402F035 RID: 192565
		[Token(Token = "0x402F035")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private CanvasGroup _selfCanvasGroup;

		// Token: 0x0402F036 RID: 192566
		[Token(Token = "0x402F036")]
		[FieldOffset(Offset = "0xE8")]
		private string m_towerId;

		// Token: 0x0402F037 RID: 192567
		[Token(Token = "0x402F037")]
		[FieldOffset(Offset = "0xF0")]
		private ClimbTowerTowerType m_towerType;

		// Token: 0x0402F03A RID: 192570
		[Token(Token = "0x402F03A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onTowerClicked;

		// Token: 0x0402F03B RID: 192571
		[Token(Token = "0x402F03B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onTowerClicked;

		// Token: 0x0402F03C RID: 192572
		[Token(Token = "0x402F03C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_page;

		// Token: 0x0402F03D RID: 192573
		[Token(Token = "0x402F03D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_page;

		// Token: 0x0402F03E RID: 192574
		[Token(Token = "0x402F03E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402F03F RID: 192575
		[Token(Token = "0x402F03F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_EventOnTowerClicked;

		// Token: 0x0402F040 RID: 192576
		[Token(Token = "0x402F040")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__RenderTowerButton;

		// Token: 0x0402F041 RID: 192577
		[Token(Token = "0x402F041")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__RenderTrainEntryButton;

		// Token: 0x0402F042 RID: 192578
		[Token(Token = "0x402F042")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
