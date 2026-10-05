using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.DeepSeaRP
{
	// Token: 0x0200512D RID: 20781
	[Token(Token = "0x200512D")]
	public class DeepSeaRPPlaceView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601EB16 RID: 125718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EB16")]
		[Address(RVA = "0x1855570", Offset = "0x1854170", VA = "0x181855570")]
		public void Render(DeepSeaRPZoneMapView mapView, DeepSeaRPPlaceModel placeModel)
		{
		}

		// Token: 0x0601EB17 RID: 125719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EB17")]
		[Address(RVA = "0x1856BE0", Offset = "0x18557E0", VA = "0x181856BE0")]
		private void _UpdateView(DeepSeaRPPlaceModel placeModel)
		{
		}

		// Token: 0x0601EB18 RID: 125720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EB18")]
		[Address(RVA = "0x18569D0", Offset = "0x18555D0", VA = "0x1818569D0")]
		private void _RenderGreyPart(DeepSeaRPNodeModel activeNodeModel)
		{
		}

		// Token: 0x0601EB19 RID: 125721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EB19")]
		[Address(RVA = "0x1856B10", Offset = "0x1855710", VA = "0x181856B10")]
		private void _RenderUnknowPart(DeepSeaRPPlaceModel placeModel)
		{
		}

		// Token: 0x0601EB1A RID: 125722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EB1A")]
		[Address(RVA = "0x1856520", Offset = "0x1855120", VA = "0x181856520")]
		private void _RenderActivePart(DeepSeaRPNodeModel activeNodeModel)
		{
		}

		// Token: 0x0601EB1B RID: 125723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EB1B")]
		[Address(RVA = "0x18562C0", Offset = "0x1854EC0", VA = "0x1818562C0")]
		private void _PlaySwitchAnim(DeepSeaRPNodeModel activeNodeModel, Action onComplete)
		{
		}

		// Token: 0x0601EB1C RID: 125724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EB1C")]
		[Address(RVA = "0x1855BF0", Offset = "0x18547F0", VA = "0x181855BF0")]
		private void _PlayCompleteAnim(bool isInverse, DeepSeaRPNodeModel activeNodeModel, Action onComplete)
		{
		}

		// Token: 0x0601EB1D RID: 125725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EB1D")]
		[Address(RVA = "0x1855F40", Offset = "0x1854B40", VA = "0x181855F40")]
		private void _PlayDiscoverAnim(Action onComplete)
		{
		}

		// Token: 0x0601EB1E RID: 125726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EB1E")]
		[Address(RVA = "0x1856100", Offset = "0x1854D00", VA = "0x181856100")]
		private void _PlayEmergeAnim(Action onComplete)
		{
		}

		// Token: 0x0601EB1F RID: 125727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EB1F")]
		[Address(RVA = "0x18552A0", Offset = "0x1853EA0", VA = "0x1818552A0")]
		public void OnNodeClick()
		{
		}

		// Token: 0x0601EB20 RID: 125728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EB20")]
		[Address(RVA = "0x1855420", Offset = "0x1854020", VA = "0x181855420")]
		public void OnPlaceDiscovered()
		{
		}

		// Token: 0x0601EB21 RID: 125729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EB21")]
		[Address(RVA = "0x1856FE0", Offset = "0x1855BE0", VA = "0x181856FE0")]
		public DeepSeaRPPlaceView()
		{
		}

		// Token: 0x0402926D RID: 168557
		[Token(Token = "0x402926D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAtlasImage _imgIcon;

		// Token: 0x0402926E RID: 168558
		[Token(Token = "0x402926E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAtlasImage _imgGreyIcon;

		// Token: 0x0402926F RID: 168559
		[Token(Token = "0x402926F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIAtlasImage _imgIconSecondary;

		// Token: 0x04029270 RID: 168560
		[Token(Token = "0x4029270")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIAtlasObject _mapAtlas;

		// Token: 0x04029271 RID: 168561
		[Token(Token = "0x4029271")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIAtlasImage _imgLock;

		// Token: 0x04029272 RID: 168562
		[Token(Token = "0x4029272")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIAtlasImage _imgRank;

		// Token: 0x04029273 RID: 168563
		[Token(Token = "0x4029273")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _textName;

		// Token: 0x04029274 RID: 168564
		[Token(Token = "0x4029274")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _battlePartGo;

		// Token: 0x04029275 RID: 168565
		[Token(Token = "0x4029275")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _textStageCode;

		// Token: 0x04029276 RID: 168566
		[Token(Token = "0x4029276")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _unknowPartGo;

		// Token: 0x04029277 RID: 168567
		[Token(Token = "0x4029277")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _unknowGlowGo;

		// Token: 0x04029278 RID: 168568
		[Token(Token = "0x4029278")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _activePartGo;

		// Token: 0x04029279 RID: 168569
		[Token(Token = "0x4029279")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _greyPartGo;

		// Token: 0x0402927A RID: 168570
		[Token(Token = "0x402927A")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _trackPointMainGo;

		// Token: 0x0402927B RID: 168571
		[Token(Token = "0x402927B")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _trackPointSubGo;

		// Token: 0x0402927C RID: 168572
		[Token(Token = "0x402927C")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GameObject _trackPointRingGo;

		// Token: 0x0402927D RID: 168573
		[Token(Token = "0x402927D")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private UIAnimationLocation _discoverAnim;

		// Token: 0x0402927E RID: 168574
		[Token(Token = "0x402927E")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private UIAnimationLocation _emergeAnim;

		// Token: 0x0402927F RID: 168575
		[Token(Token = "0x402927F")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private UIAnimationLocation _switchAnim;

		// Token: 0x04029280 RID: 168576
		[Token(Token = "0x4029280")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private UIAnimationLocation _completeAnim;

		// Token: 0x04029281 RID: 168577
		[Token(Token = "0x4029281")]
		[FieldOffset(Offset = "0xD8")]
		private PlayerDeepSea.PlaceStatus? m_cachedPlaceStatus;

		// Token: 0x04029282 RID: 168578
		[Token(Token = "0x4029282")]
		[FieldOffset(Offset = "0xE0")]
		private Act17sideData.NodeType? m_cachedNodeType;

		// Token: 0x04029283 RID: 168579
		[Token(Token = "0x4029283")]
		[FieldOffset(Offset = "0xE8")]
		private bool? m_cachedGreyStatus;

		// Token: 0x04029284 RID: 168580
		[Token(Token = "0x4029284")]
		[FieldOffset(Offset = "0xF0")]
		private DeepSeaRPNodeModel m_activeNodeModel;

		// Token: 0x04029285 RID: 168581
		[Token(Token = "0x4029285")]
		[FieldOffset(Offset = "0xF8")]
		private DeepSeaRPPlaceModel m_placeModel;

		// Token: 0x04029286 RID: 168582
		[Token(Token = "0x4029286")]
		[FieldOffset(Offset = "0x100")]
		private DeepSeaRPZoneMapView m_mapView;

		// Token: 0x04029287 RID: 168583
		[Token(Token = "0x4029287")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04029288 RID: 168584
		[Token(Token = "0x4029288")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__UpdateView;

		// Token: 0x04029289 RID: 168585
		[Token(Token = "0x4029289")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RenderGreyPart;

		// Token: 0x0402928A RID: 168586
		[Token(Token = "0x402928A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RenderUnknowPart;

		// Token: 0x0402928B RID: 168587
		[Token(Token = "0x402928B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RenderActivePart;

		// Token: 0x0402928C RID: 168588
		[Token(Token = "0x402928C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__PlaySwitchAnim;

		// Token: 0x0402928D RID: 168589
		[Token(Token = "0x402928D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__PlayCompleteAnim;

		// Token: 0x0402928E RID: 168590
		[Token(Token = "0x402928E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__PlayDiscoverAnim;

		// Token: 0x0402928F RID: 168591
		[Token(Token = "0x402928F")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__PlayEmergeAnim;

		// Token: 0x04029290 RID: 168592
		[Token(Token = "0x4029290")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnNodeClick;

		// Token: 0x04029291 RID: 168593
		[Token(Token = "0x4029291")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnPlaceDiscovered;

		// Token: 0x04029292 RID: 168594
		[Token(Token = "0x4029292")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
