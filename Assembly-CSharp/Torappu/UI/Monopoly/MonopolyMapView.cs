using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Monopoly
{
	// Token: 0x020047FF RID: 18431
	[Token(Token = "0x20047FF")]
	public class MonopolyMapView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601BDF8 RID: 114168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BDF8")]
		[Address(RVA = "0x1542650", Offset = "0x1541250", VA = "0x181542650")]
		public void Render(MonopolyGameDetailViewModel gameModel)
		{
		}

		// Token: 0x0601BDF9 RID: 114169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BDF9")]
		[Address(RVA = "0x1542C10", Offset = "0x1541810", VA = "0x181542C10")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601BDFA RID: 114170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BDFA")]
		[Address(RVA = "0x15434F0", Offset = "0x15420F0", VA = "0x1815434F0")]
		private void _ReloadNodeContainerIfNeed(string mapId)
		{
		}

		// Token: 0x0601BDFB RID: 114171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BDFB")]
		[Address(RVA = "0x1543640", Offset = "0x1542240", VA = "0x181543640")]
		private void _RenderCommonRefreshPart(MonopolyGameDetailViewModel gameModel)
		{
		}

		// Token: 0x0601BDFC RID: 114172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BDFC")]
		[Address(RVA = "0x15438F0", Offset = "0x15424F0", VA = "0x1815438F0")]
		private void _RenderMapImmediately(MonopolyGameDetailViewModel gameModel)
		{
		}

		// Token: 0x0601BDFD RID: 114173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BDFD")]
		[Address(RVA = "0x1543210", Offset = "0x1541E10", VA = "0x181543210")]
		private void _PlayMoveTween(MonopolyGameDetailViewModel gameModel)
		{
		}

		// Token: 0x0601BDFE RID: 114174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BDFE")]
		[Address(RVA = "0x1542FC0", Offset = "0x1541BC0", VA = "0x181542FC0")]
		private void _PlayMiningTween(MonopolyGameDetailViewModel gameModel)
		{
		}

		// Token: 0x0601BDFF RID: 114175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BDFF")]
		[Address(RVA = "0x1542DD0", Offset = "0x15419D0", VA = "0x181542DD0")]
		private void _PlayEndRoundTween(MonopolyGameDetailViewModel gameModel)
		{
		}

		// Token: 0x0601BE00 RID: 114176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BE00")]
		[Address(RVA = "0x1542AD0", Offset = "0x15416D0", VA = "0x181542AD0")]
		private void _CleanPlayingTween()
		{
		}

		// Token: 0x0601BE01 RID: 114177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BE01")]
		[Address(RVA = "0x1543B30", Offset = "0x1542730", VA = "0x181543B30")]
		private void _SetMoveAnimToEnd()
		{
		}

		// Token: 0x0601BE02 RID: 114178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BE02")]
		[Address(RVA = "0x1543AC0", Offset = "0x15426C0", VA = "0x181543AC0")]
		private void _SetMiningAnimToEnd()
		{
		}

		// Token: 0x0601BE03 RID: 114179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BE03")]
		[Address(RVA = "0x15425B0", Offset = "0x15411B0", VA = "0x1815425B0")]
		public void RegisterMapTutorialGo()
		{
		}

		// Token: 0x0601BE04 RID: 114180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BE04")]
		[Address(RVA = "0x1543BA0", Offset = "0x15427A0", VA = "0x181543BA0")]
		public MonopolyMapView()
		{
		}

		// Token: 0x040244F0 RID: 148720
		[Token(Token = "0x40244F0")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform _playerPos;

		// Token: 0x040244F1 RID: 148721
		[Token(Token = "0x40244F1")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _playerNextPos;

		// Token: 0x040244F2 RID: 148722
		[Token(Token = "0x40244F2")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _nodeContainerParent;

		// Token: 0x040244F3 RID: 148723
		[Token(Token = "0x40244F3")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIAnimationLocation _currPosFadeSwitchAnim;

		// Token: 0x040244F4 RID: 148724
		[Token(Token = "0x40244F4")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UIAnimationLocation _nextPosShowAnim;

		// Token: 0x040244F5 RID: 148725
		[Token(Token = "0x40244F5")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UIAnimationLocation _currPosMoveHintAnim;

		// Token: 0x040244F6 RID: 148726
		[Token(Token = "0x40244F6")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private UIAnimationLocation _miningHintAnim;

		// Token: 0x040244F7 RID: 148727
		[Token(Token = "0x40244F7")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _miningResourceCount;

		// Token: 0x040244F8 RID: 148728
		[Token(Token = "0x40244F8")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Image[] _resourceTypeIcon;

		// Token: 0x040244F9 RID: 148729
		[Token(Token = "0x40244F9")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private float _miningPreviewSwitchDuration;

		// Token: 0x040244FA RID: 148730
		[Token(Token = "0x40244FA")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _mapPanelTutorialGo;

		// Token: 0x040244FB RID: 148731
		[Token(Token = "0x40244FB")]
		[FieldOffset(Offset = "0x90")]
		private bool m_hasInited;

		// Token: 0x040244FC RID: 148732
		[Token(Token = "0x40244FC")]
		[FieldOffset(Offset = "0x98")]
		private UIPageFinder m_pageFinder;

		// Token: 0x040244FD RID: 148733
		[Token(Token = "0x40244FD")]
		[FieldOffset(Offset = "0xA8")]
		private MonopolyMapNodeContainer m_nodeContainer;

		// Token: 0x040244FE RID: 148734
		[Token(Token = "0x40244FE")]
		[FieldOffset(Offset = "0xB0")]
		private string m_cacheMapId;

		// Token: 0x040244FF RID: 148735
		[Token(Token = "0x40244FF")]
		[FieldOffset(Offset = "0xB8")]
		private int m_enterSeqNum;

		// Token: 0x04024500 RID: 148736
		[Token(Token = "0x4024500")]
		[FieldOffset(Offset = "0xBC")]
		private int m_cardSelectSeqNum;

		// Token: 0x04024501 RID: 148737
		[Token(Token = "0x4024501")]
		[FieldOffset(Offset = "0xC0")]
		private UISwitchTween m_currPosTween;

		// Token: 0x04024502 RID: 148738
		[Token(Token = "0x4024502")]
		[FieldOffset(Offset = "0xC8")]
		private UISwitchTween m_nextPosTween;

		// Token: 0x04024503 RID: 148739
		[Token(Token = "0x4024503")]
		[FieldOffset(Offset = "0xD0")]
		private Tween m_mapTween;

		// Token: 0x04024504 RID: 148740
		[Token(Token = "0x4024504")]
		[FieldOffset(Offset = "0xD8")]
		private string m_cacheMiningResourceId;

		// Token: 0x04024505 RID: 148741
		[Token(Token = "0x4024505")]
		[FieldOffset(Offset = "0xE0")]
		private int m_gameActSeqNum;

		// Token: 0x04024506 RID: 148742
		[Token(Token = "0x4024506")]
		[FieldOffset(Offset = "0xE4")]
		private MonopolyEventType m_cacheEventType;

		// Token: 0x04024507 RID: 148743
		[Token(Token = "0x4024507")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04024508 RID: 148744
		[Token(Token = "0x4024508")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04024509 RID: 148745
		[Token(Token = "0x4024509")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__ReloadNodeContainerIfNeed;

		// Token: 0x0402450A RID: 148746
		[Token(Token = "0x402450A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RenderCommonRefreshPart;

		// Token: 0x0402450B RID: 148747
		[Token(Token = "0x402450B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RenderMapImmediately;

		// Token: 0x0402450C RID: 148748
		[Token(Token = "0x402450C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__PlayMoveTween;

		// Token: 0x0402450D RID: 148749
		[Token(Token = "0x402450D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__PlayMiningTween;

		// Token: 0x0402450E RID: 148750
		[Token(Token = "0x402450E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__PlayEndRoundTween;

		// Token: 0x0402450F RID: 148751
		[Token(Token = "0x402450F")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__CleanPlayingTween;

		// Token: 0x04024510 RID: 148752
		[Token(Token = "0x4024510")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__SetMoveAnimToEnd;

		// Token: 0x04024511 RID: 148753
		[Token(Token = "0x4024511")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__SetMiningAnimToEnd;

		// Token: 0x04024512 RID: 148754
		[Token(Token = "0x4024512")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_RegisterMapTutorialGo;

		// Token: 0x04024513 RID: 148755
		[Token(Token = "0x4024513")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
