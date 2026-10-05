using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using XLua;

namespace Torappu.UI.Medal
{
	// Token: 0x02004937 RID: 18743
	[Token(Token = "0x2004937")]
	public class UIMedalDIYManager : MonoBehaviour, IHotfixable
	{
		// Token: 0x170042FB RID: 17147
		// (get) Token: 0x0601C408 RID: 115720 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170042FB")]
		public MedalDIYViewModel model
		{
			[Token(Token = "0x601C408")]
			[Address(RVA = "0x15BDF80", Offset = "0x15BCB80", VA = "0x1815BDF80")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601C409 RID: 115721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C409")]
		[Address(RVA = "0x15BB3A0", Offset = "0x15B9FA0", VA = "0x1815BB3A0")]
		public void NotifyDataChanged()
		{
		}

		// Token: 0x0601C40A RID: 115722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C40A")]
		[Address(RVA = "0x15BB260", Offset = "0x15B9E60", VA = "0x1815BB260")]
		public void Init(UIPage page)
		{
		}

		// Token: 0x0601C40B RID: 115723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C40B")]
		[Address(RVA = "0x15BB400", Offset = "0x15BA000", VA = "0x1815BB400")]
		private void OnDisable()
		{
		}

		// Token: 0x0601C40C RID: 115724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C40C")]
		[Address(RVA = "0x15BB460", Offset = "0x15BA060", VA = "0x1815BB460")]
		private void Update()
		{
		}

		// Token: 0x0601C40D RID: 115725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C40D")]
		[Address(RVA = "0x15BB510", Offset = "0x15BA110", VA = "0x1815BB510")]
		private void _BeginDragFromToken(string medalId)
		{
		}

		// Token: 0x0601C40E RID: 115726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C40E")]
		[Address(RVA = "0x15BBFB0", Offset = "0x15BABB0", VA = "0x1815BBFB0")]
		private void _DragCardFromList(string medalId, PointerEventData eventData)
		{
		}

		// Token: 0x0601C40F RID: 115727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C40F")]
		[Address(RVA = "0x15BC2E0", Offset = "0x15BAEE0", VA = "0x1815BC2E0")]
		private void _EndDragFromToken(string medalId)
		{
		}

		// Token: 0x0601C410 RID: 115728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C410")]
		[Address(RVA = "0x15BC810", Offset = "0x15BB410", VA = "0x1815BC810")]
		private void _PointDownFromToken(string medalId, PointerEventData eventData)
		{
		}

		// Token: 0x0601C411 RID: 115729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C411")]
		[Address(RVA = "0x15BC7B0", Offset = "0x15BB3B0", VA = "0x1815BC7B0")]
		private void _OnMedalTokenReleased()
		{
		}

		// Token: 0x0601C412 RID: 115730 RVA: 0x000A7AF0 File Offset: 0x000A5CF0
		[Token(Token = "0x601C412")]
		[Address(RVA = "0x15BBB50", Offset = "0x15BA750", VA = "0x1815BBB50")]
		private UIMedalDIYManager.DragStatus _CreateDragStatus(string medalId, PointerEventData eventData)
		{
			return default(UIMedalDIYManager.DragStatus);
		}

		// Token: 0x0601C413 RID: 115731 RVA: 0x000A7B08 File Offset: 0x000A5D08
		[Token(Token = "0x601C413")]
		[Address(RVA = "0x15BC340", Offset = "0x15BAF40", VA = "0x1815BC340")]
		private static bool _GetLocalCursorPoint(int pointerId, RectTransform local, Camera eventCam, out Vector2 localPos)
		{
			return default(bool);
		}

		// Token: 0x0601C414 RID: 115732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C414")]
		[Address(RVA = "0x15BBA60", Offset = "0x15BA660", VA = "0x1815BBA60")]
		private void _ClearDraggingAndResetStatus(bool immediately)
		{
		}

		// Token: 0x0601C415 RID: 115733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C415")]
		[Address(RVA = "0x15BCB80", Offset = "0x15BB780", VA = "0x1815BCB80")]
		private void _ResetAllStatus(bool immediately)
		{
		}

		// Token: 0x0601C416 RID: 115734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C416")]
		[Address(RVA = "0x15BD7C0", Offset = "0x15BC3C0", VA = "0x1815BD7C0")]
		private void _UpdateStatus()
		{
		}

		// Token: 0x0601C417 RID: 115735 RVA: 0x000A7B20 File Offset: 0x000A5D20
		[Token(Token = "0x601C417")]
		[Address(RVA = "0x15BD4B0", Offset = "0x15BC0B0", VA = "0x1815BD4B0")]
		private UIMedalDIYFrame.PosValidateResult _UpdateStatusLastValidPos(UIMedalDIYFrame frame)
		{
			return default(UIMedalDIYFrame.PosValidateResult);
		}

		// Token: 0x0601C418 RID: 115736 RVA: 0x000A7B38 File Offset: 0x000A5D38
		[Token(Token = "0x601C418")]
		[Address(RVA = "0x15BD150", Offset = "0x15BBD50", VA = "0x1815BD150")]
		private UIMedalDIYFrame.PosValidateResult _UpdateLastValidPosOnRoute(HexPoint srcPos, HexPoint dstPos, UIMedalDIYFrame.MedalPosInfo targetPos, List<UIMedalDIYFrame.MedalPosInfo> otherPos, UIMedalDIYFrame frame)
		{
			return default(UIMedalDIYFrame.PosValidateResult);
		}

		// Token: 0x0601C419 RID: 115737 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C419")]
		[Address(RVA = "0x15BC4D0", Offset = "0x15BB0D0", VA = "0x1815BC4D0")]
		private List<UIMedalDIYFrame.MedalPosInfo> _LoadOtherMedalPosInfoToValidate()
		{
			return null;
		}

		// Token: 0x0601C41A RID: 115738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C41A")]
		[Address(RVA = "0x15BDA10", Offset = "0x15BC610", VA = "0x1815BDA10")]
		private void _UpdateValidPosView(bool immediately)
		{
		}

		// Token: 0x0601C41B RID: 115739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C41B")]
		[Address(RVA = "0x15BB5A0", Offset = "0x15BA1A0", VA = "0x1815BB5A0")]
		private void _CalcHexPosLerpInCardList(ListDict<string, HexPoint> medalPosList, ref ListDict<string, float> lerpList)
		{
		}

		// Token: 0x0601C41C RID: 115740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C41C")]
		[Address(RVA = "0x15BD050", Offset = "0x15BBC50", VA = "0x1815BD050")]
		private void _UpdateDataAndNotify(bool immediately)
		{
		}

		// Token: 0x0601C41D RID: 115741 RVA: 0x000A7B50 File Offset: 0x000A5D50
		[Token(Token = "0x601C41D")]
		[Address(RVA = "0x15BB990", Offset = "0x15BA590", VA = "0x1815BB990")]
		private static bool _CheckIfToRemoveLastValidPos(HexPoint curPos, HexPoint lastValidPos, UIMedalDIYFrame.PosValidateResult validRet)
		{
			return default(bool);
		}

		// Token: 0x0601C41E RID: 115742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C41E")]
		[Address(RVA = "0x15BDBF0", Offset = "0x15BC7F0", VA = "0x1815BDBF0")]
		public UIMedalDIYManager()
		{
		}

		// Token: 0x04024F43 RID: 151363
		[Token(Token = "0x4024F43")]
		private const int MAX_STEP_COUNT = 20;

		// Token: 0x04024F44 RID: 151364
		[Token(Token = "0x4024F44")]
		private const int REMOVE_TOKEN_DIST = 12;

		// Token: 0x04024F45 RID: 151365
		[Token(Token = "0x4024F45")]
		private const int REMOVE_TOKEN_VERTICE_NUM = 4;

		// Token: 0x04024F46 RID: 151366
		[Token(Token = "0x4024F46")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIMedalDIYTokenLayouter _tokenLayout;

		// Token: 0x04024F47 RID: 151367
		[Token(Token = "0x4024F47")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIMedalDIYCardList _cardList;

		// Token: 0x04024F48 RID: 151368
		[Token(Token = "0x4024F48")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIMedalDIYValidPosView _validPosView;

		// Token: 0x04024F49 RID: 151369
		[Token(Token = "0x4024F49")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Tooltip("Used to block buttons during interacting on tokens")]
		private GameObject _tokenBlocker;

		// Token: 0x04024F4A RID: 151370
		[Token(Token = "0x4024F4A")]
		[FieldOffset(Offset = "0x38")]
		private UIMedalDIYManager.DIYContext m_context;

		// Token: 0x04024F4B RID: 151371
		[Token(Token = "0x4024F4B")]
		[FieldOffset(Offset = "0x40")]
		private UIMedalDIYManager.DragStatus m_dragStatus;

		// Token: 0x04024F4C RID: 151372
		[Token(Token = "0x4024F4C")]
		[FieldOffset(Offset = "0x98")]
		private MedalDIYViewModel m_model;

		// Token: 0x04024F4D RID: 151373
		[Token(Token = "0x4024F4D")]
		[FieldOffset(Offset = "0xA0")]
		private ListDict<string, HexPoint> m_sharedMedalPos;

		// Token: 0x04024F4E RID: 151374
		[Token(Token = "0x4024F4E")]
		[FieldOffset(Offset = "0xA8")]
		private List<UIMedalDIYFrame.MedalPosInfo> m_sharedPosInfo;

		// Token: 0x04024F4F RID: 151375
		[Token(Token = "0x4024F4F")]
		[FieldOffset(Offset = "0xB0")]
		private ListDict<string, float> m_sharedLerpInfo;

		// Token: 0x04024F50 RID: 151376
		[Token(Token = "0x4024F50")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_model;

		// Token: 0x04024F51 RID: 151377
		[Token(Token = "0x4024F51")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_NotifyDataChanged;

		// Token: 0x04024F52 RID: 151378
		[Token(Token = "0x4024F52")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04024F53 RID: 151379
		[Token(Token = "0x4024F53")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnDisable;

		// Token: 0x04024F54 RID: 151380
		[Token(Token = "0x4024F54")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x04024F55 RID: 151381
		[Token(Token = "0x4024F55")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__BeginDragFromToken;

		// Token: 0x04024F56 RID: 151382
		[Token(Token = "0x4024F56")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__DragCardFromList;

		// Token: 0x04024F57 RID: 151383
		[Token(Token = "0x4024F57")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__EndDragFromToken;

		// Token: 0x04024F58 RID: 151384
		[Token(Token = "0x4024F58")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__PointDownFromToken;

		// Token: 0x04024F59 RID: 151385
		[Token(Token = "0x4024F59")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OnMedalTokenReleased;

		// Token: 0x04024F5A RID: 151386
		[Token(Token = "0x4024F5A")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__CreateDragStatus;

		// Token: 0x04024F5B RID: 151387
		[Token(Token = "0x4024F5B")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__GetLocalCursorPoint;

		// Token: 0x04024F5C RID: 151388
		[Token(Token = "0x4024F5C")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__ClearDraggingAndResetStatus;

		// Token: 0x04024F5D RID: 151389
		[Token(Token = "0x4024F5D")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__ResetAllStatus;

		// Token: 0x04024F5E RID: 151390
		[Token(Token = "0x4024F5E")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__UpdateStatus;

		// Token: 0x04024F5F RID: 151391
		[Token(Token = "0x4024F5F")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__UpdateStatusLastValidPos;

		// Token: 0x04024F60 RID: 151392
		[Token(Token = "0x4024F60")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__UpdateLastValidPosOnRoute;

		// Token: 0x04024F61 RID: 151393
		[Token(Token = "0x4024F61")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__LoadOtherMedalPosInfoToValidate;

		// Token: 0x04024F62 RID: 151394
		[Token(Token = "0x4024F62")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__UpdateValidPosView;

		// Token: 0x04024F63 RID: 151395
		[Token(Token = "0x4024F63")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__CalcHexPosLerpInCardList;

		// Token: 0x04024F64 RID: 151396
		[Token(Token = "0x4024F64")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__UpdateDataAndNotify;

		// Token: 0x04024F65 RID: 151397
		[Token(Token = "0x4024F65")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__CheckIfToRemoveLastValidPos;

		// Token: 0x04024F66 RID: 151398
		[Token(Token = "0x4024F66")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004938 RID: 18744
		[Token(Token = "0x2004938")]
		private class DIYContext : IMedalDIYContext
		{
			// Token: 0x0601C41F RID: 115743 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601C41F")]
			[Address(RVA = "0x4ECFE0", Offset = "0x4EBBE0", VA = "0x1804ECFE0")]
			public DIYContext(UIPage page, UIMedalDIYManager mgr)
			{
			}

			// Token: 0x0601C420 RID: 115744 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601C420")]
			[Address(RVA = "0x15ABA60", Offset = "0x15AA660", VA = "0x1815ABA60", Slot = "5")]
			public void BeginDragFromToken(string medalId)
			{
			}

			// Token: 0x0601C421 RID: 115745 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601C421")]
			[Address(RVA = "0x15ABB00", Offset = "0x15AA700", VA = "0x1815ABB00", Slot = "8")]
			public void DragCardFromList(string medalId, PointerEventData eventData)
			{
			}

			// Token: 0x0601C422 RID: 115746 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601C422")]
			[Address(RVA = "0x15ABB20", Offset = "0x15AA720", VA = "0x1815ABB20", Slot = "6")]
			public void EndDragFromToken(string medalId)
			{
			}

			// Token: 0x0601C423 RID: 115747 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601C423")]
			[Address(RVA = "0x15ABC60", Offset = "0x15AA860", VA = "0x1815ABC60", Slot = "7")]
			public void PointDownFromToken(string medalId, PointerEventData eventData)
			{
			}

			// Token: 0x0601C424 RID: 115748 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601C424")]
			public T LoadAsset<T>(string path) where T : UnityEngine.Object
			{
				return null;
			}

			// Token: 0x0601C425 RID: 115749 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601C425")]
			[Address(RVA = "0x15ABBB0", Offset = "0x15AA7B0", VA = "0x1815ABBB0", Slot = "9")]
			public Sprite LoadMedalIcon(string spriteId)
			{
				return null;
			}

			// Token: 0x0601C426 RID: 115750 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601C426")]
			[Address(RVA = "0x15ABB90", Offset = "0x15AA790", VA = "0x1815ABB90", Slot = "10")]
			public string GetTargetMedalId()
			{
				return null;
			}

			// Token: 0x0601C427 RID: 115751 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601C427")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "11")]
			public UIPage GetPage()
			{
				return null;
			}

			// Token: 0x04024F67 RID: 151399
			[Token(Token = "0x4024F67")]
			[FieldOffset(Offset = "0x10")]
			private UIPage m_page;

			// Token: 0x04024F68 RID: 151400
			[Token(Token = "0x4024F68")]
			[FieldOffset(Offset = "0x18")]
			private UIMedalDIYManager m_mgr;
		}

		// Token: 0x02004939 RID: 18745
		[Token(Token = "0x2004939")]
		private struct DragStatus
		{
			// Token: 0x0601C428 RID: 115752 RVA: 0x000A7B68 File Offset: 0x000A5D68
			[Token(Token = "0x601C428")]
			[Address(RVA = "0x15ABED0", Offset = "0x15AAAD0", VA = "0x1815ABED0")]
			public bool IsValid()
			{
				return default(bool);
			}

			// Token: 0x04024F69 RID: 151401
			[Token(Token = "0x4024F69")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIMedalDIYManager.DragStatus NONE;

			// Token: 0x04024F6A RID: 151402
			[Token(Token = "0x4024F6A")]
			[FieldOffset(Offset = "0x0")]
			public bool isDragging;

			// Token: 0x04024F6B RID: 151403
			[Token(Token = "0x4024F6B")]
			[FieldOffset(Offset = "0x8")]
			public string targetId;

			// Token: 0x04024F6C RID: 151404
			[Token(Token = "0x4024F6C")]
			[FieldOffset(Offset = "0x10")]
			public UIMedalDIYTokenView target;

			// Token: 0x04024F6D RID: 151405
			[Token(Token = "0x4024F6D")]
			[FieldOffset(Offset = "0x18")]
			public DIYMedalModel targetModel;

			// Token: 0x04024F6E RID: 151406
			[Token(Token = "0x4024F6E")]
			[FieldOffset(Offset = "0x20")]
			public Camera eventCam;

			// Token: 0x04024F6F RID: 151407
			[Token(Token = "0x4024F6F")]
			[FieldOffset(Offset = "0x28")]
			public int pointerId;

			// Token: 0x04024F70 RID: 151408
			[Token(Token = "0x4024F70")]
			[FieldOffset(Offset = "0x2C")]
			public Vector2 targetStartPos;

			// Token: 0x04024F71 RID: 151409
			[Token(Token = "0x4024F71")]
			[FieldOffset(Offset = "0x34")]
			public Vector2 pointDownPos;

			// Token: 0x04024F72 RID: 151410
			[Token(Token = "0x4024F72")]
			[FieldOffset(Offset = "0x3C")]
			public bool hasLastPos;

			// Token: 0x04024F73 RID: 151411
			[Token(Token = "0x4024F73")]
			[FieldOffset(Offset = "0x40")]
			public HexPoint lastPos;

			// Token: 0x04024F74 RID: 151412
			[Token(Token = "0x4024F74")]
			[FieldOffset(Offset = "0x48")]
			public bool hasLastValidPos;

			// Token: 0x04024F75 RID: 151413
			[Token(Token = "0x4024F75")]
			[FieldOffset(Offset = "0x4C")]
			public HexPoint lastValidPos;
		}
	}
}
