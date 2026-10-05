using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Torappu.Building.UI;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Building.DIY.UI
{
	// Token: 0x020019AB RID: 6571
	[Token(Token = "0x20019AB")]
	public class DIYUIController : PageSingleComponent, IHotfixable
	{
		// Token: 0x1700130A RID: 4874
		// (get) Token: 0x0600A4FA RID: 42234 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700130A")]
		public StateEngine bottomStateEngine
		{
			[Token(Token = "0x600A4FA")]
			[Address(RVA = "0x31FA390", Offset = "0x31F8F90", VA = "0x1831FA390")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700130B RID: 4875
		// (get) Token: 0x0600A4FB RID: 42235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700130B")]
		public GameObject backButton
		{
			[Token(Token = "0x600A4FB")]
			[Address(RVA = "0x31FA330", Offset = "0x31F8F30", VA = "0x1831FA330")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600A4FC RID: 42236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A4FC")]
		[Address(RVA = "0x31F8F90", Offset = "0x31F7B90", VA = "0x1831F8F90")]
		public void Setup(DIYPage.UIHandler pageHandler)
		{
		}

		// Token: 0x0600A4FD RID: 42237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A4FD")]
		[Address(RVA = "0x31F8090", Offset = "0x31F6C90", VA = "0x1831F8090")]
		public void NotifyFurnitureUnequiped(Furniture furniture)
		{
		}

		// Token: 0x0600A4FE RID: 42238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A4FE")]
		[Address(RVA = "0x31F7F80", Offset = "0x31F6B80", VA = "0x1831F7F80")]
		public void NotifyFurnitureRegistered(DIYRoom.IFurnitureController controller)
		{
		}

		// Token: 0x0600A4FF RID: 42239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A4FF")]
		[Address(RVA = "0x31F8130", Offset = "0x31F6D30", VA = "0x1831F8130")]
		public void NotifyFurnitureUnregistered(DIYRoom.IFurnitureController controller)
		{
		}

		// Token: 0x0600A500 RID: 42240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A500")]
		[Address(RVA = "0x31F81D0", Offset = "0x31F6DD0", VA = "0x1831F81D0")]
		public void NotifyModifierChanged(DIYRoomModifier pre, DIYRoomModifier post)
		{
		}

		// Token: 0x0600A501 RID: 42241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A501")]
		[Address(RVA = "0x31F8360", Offset = "0x31F6F60", VA = "0x1831F8360")]
		public void NotifyResetAllChanges()
		{
		}

		// Token: 0x0600A502 RID: 42242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A502")]
		[Address(RVA = "0x31F7EF0", Offset = "0x31F6AF0", VA = "0x1831F7EF0")]
		public void NotifyClearAllFurnitures()
		{
		}

		// Token: 0x0600A503 RID: 42243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A503")]
		[Address(RVA = "0x31F83F0", Offset = "0x31F6FF0", VA = "0x1831F83F0")]
		public void NotifyThemeApplied()
		{
		}

		// Token: 0x0600A504 RID: 42244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A504")]
		[Address(RVA = "0x31F8290", Offset = "0x31F6E90", VA = "0x1831F8290")]
		public void NotifyPresetApplied()
		{
		}

		// Token: 0x0600A505 RID: 42245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A505")]
		[Address(RVA = "0x31F8020", Offset = "0x31F6C20", VA = "0x1831F8020")]
		public void NotifyFurnitureSaved()
		{
		}

		// Token: 0x0600A506 RID: 42246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A506")]
		[Address(RVA = "0x31F7DF0", Offset = "0x31F69F0", VA = "0x1831F7DF0")]
		public void NotifyCameraChanged(DIYPage.CameraStateType cameraStateType)
		{
		}

		// Token: 0x0600A507 RID: 42247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A507")]
		[Address(RVA = "0x31F7D10", Offset = "0x31F6910", VA = "0x1831F7D10")]
		public void MarkFurnitureChanged()
		{
		}

		// Token: 0x0600A508 RID: 42248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A508")]
		[Address(RVA = "0x31F7D80", Offset = "0x31F6980", VA = "0x1831F7D80")]
		public void MarkModifierChanged()
		{
		}

		// Token: 0x0600A509 RID: 42249 RVA: 0x000400C8 File Offset: 0x0003E2C8
		[Token(Token = "0x600A509")]
		[Address(RVA = "0x31F7CC0", Offset = "0x31F68C0", VA = "0x1831F7CC0")]
		public static int GetUIBottomMargin()
		{
			return 0;
		}

		// Token: 0x0600A50A RID: 42250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A50A")]
		[Address(RVA = "0x31F96F0", Offset = "0x31F82F0", VA = "0x1831F96F0")]
		private void _InitIfNot(DIYPage.UIHandler pageHandler)
		{
		}

		// Token: 0x0600A50B RID: 42251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A50B")]
		[Address(RVA = "0x31F9AB0", Offset = "0x31F86B0", VA = "0x1831F9AB0")]
		private void _InitRoomTitle()
		{
		}

		// Token: 0x0600A50C RID: 42252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A50C")]
		[Address(RVA = "0x31F9D00", Offset = "0x31F8900", VA = "0x1831F9D00")]
		private void _OnBackPressAction()
		{
		}

		// Token: 0x0600A50D RID: 42253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A50D")]
		[Address(RVA = "0x31FA140", Offset = "0x31F8D40", VA = "0x1831FA140")]
		private void _ShowJudgeDialog(string content, [Optional] Action positiveAction)
		{
		}

		// Token: 0x0600A50E RID: 42254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A50E")]
		[Address(RVA = "0x31F8D70", Offset = "0x31F7970", VA = "0x1831F8D70")]
		public void OnTopMenuBackButtonPressed()
		{
		}

		// Token: 0x0600A50F RID: 42255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A50F")]
		[Address(RVA = "0x31F89F0", Offset = "0x31F75F0", VA = "0x1831F89F0")]
		public void OnSaveButtonPressed()
		{
		}

		// Token: 0x0600A510 RID: 42256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A510")]
		[Address(RVA = "0x31F85E0", Offset = "0x31F71E0", VA = "0x1831F85E0")]
		public void OnClearButtonPressed()
		{
		}

		// Token: 0x0600A511 RID: 42257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A511")]
		[Address(RVA = "0x31F8900", Offset = "0x31F7500", VA = "0x1831F8900")]
		public void OnResetButtonPressed()
		{
		}

		// Token: 0x0600A512 RID: 42258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A512")]
		[Address(RVA = "0x31F8B50", Offset = "0x31F7750", VA = "0x1831F8B50")]
		public void OnShopPressed()
		{
		}

		// Token: 0x0600A513 RID: 42259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A513")]
		[Address(RVA = "0x31F86D0", Offset = "0x31F72D0", VA = "0x1831F86D0")]
		public void OnComfortPressed()
		{
		}

		// Token: 0x0600A514 RID: 42260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A514")]
		[Address(RVA = "0x31F8890", Offset = "0x31F7490", VA = "0x1831F8890")]
		public void OnManifestBGPressed()
		{
		}

		// Token: 0x0600A515 RID: 42261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A515")]
		[Address(RVA = "0x31F8570", Offset = "0x31F7170", VA = "0x1831F8570")]
		public void OnCeilDirectlyButtonPressed()
		{
		}

		// Token: 0x0600A516 RID: 42262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A516")]
		[Address(RVA = "0x31F8820", Offset = "0x31F7420", VA = "0x1831F8820")]
		public void OnFloorDirectlyButtonPressed()
		{
		}

		// Token: 0x0600A517 RID: 42263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A517")]
		[Address(RVA = "0x31F8F20", Offset = "0x31F7B20", VA = "0x1831F8F20")]
		public void OnWallButtonPressed()
		{
		}

		// Token: 0x0600A518 RID: 42264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A518")]
		[Address(RVA = "0x31F8500", Offset = "0x31F7100", VA = "0x1831F8500")]
		public void OnCameraResetButtonPressed()
		{
		}

		// Token: 0x0600A519 RID: 42265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A519")]
		[Address(RVA = "0x31FA2D0", Offset = "0x31F8ED0", VA = "0x1831FA2D0")]
		public DIYUIController()
		{
		}

		// Token: 0x04009C4A RID: 40010
		[Token(Token = "0x4009C4A")]
		private const int VIEWPORT_BOTTOM_MARGIN = 300;

		// Token: 0x04009C4B RID: 40011
		[Token(Token = "0x4009C4B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _comfortPanel;

		// Token: 0x04009C4C RID: 40012
		[Token(Token = "0x4009C4C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private BuildingUIRoomTitle _roomTitle;

		// Token: 0x04009C4D RID: 40013
		[Token(Token = "0x4009C4D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private DIYComfortDetailView _comfortDetailView;

		// Token: 0x04009C4E RID: 40014
		[Token(Token = "0x4009C4E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _shopBtnPanel;

		// Token: 0x04009C4F RID: 40015
		[Token(Token = "0x4009C4F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private PrefabInstHolder _shopPanelHolder;

		// Token: 0x04009C50 RID: 40016
		[Token(Token = "0x4009C50")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private DIYFurnitureDetailPanel _furnitureDetailPanel;

		// Token: 0x04009C51 RID: 40017
		[Token(Token = "0x4009C51")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private DIYCameraSwitchToggle _cameraSwitchToggle;

		// Token: 0x04009C52 RID: 40018
		[Token(Token = "0x4009C52")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private int _viewportBottomMargin;

		// Token: 0x04009C53 RID: 40019
		[Token(Token = "0x4009C53")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private StateEngine _bottomStateEngine;

		// Token: 0x04009C54 RID: 40020
		[Token(Token = "0x4009C54")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private DIYListViewStateBean _stateBean;

		// Token: 0x04009C55 RID: 40021
		[Token(Token = "0x4009C55")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _backButton;

		// Token: 0x04009C56 RID: 40022
		[Token(Token = "0x4009C56")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private DIYPage.UIHandler m_pageHandler;

		// Token: 0x04009C57 RID: 40023
		[Token(Token = "0x4009C57")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private DIYListViewStateBean.StateBeanHandler m_stateBeanHandler;

		// Token: 0x04009C58 RID: 40024
		[Token(Token = "0x4009C58")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private DIYShopPanel m_shopPanel;

		// Token: 0x04009C59 RID: 40025
		[Token(Token = "0x4009C59")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool m_isInited;

		// Token: 0x04009C5A RID: 40026
		[Token(Token = "0x4009C5A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x91")]
		private bool m_furnitureChanged;

		// Token: 0x04009C5B RID: 40027
		[Token(Token = "0x4009C5B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x92")]
		private bool m_modifierChanged;

		// Token: 0x04009C5C RID: 40028
		[Token(Token = "0x4009C5C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_bottomStateEngine;

		// Token: 0x04009C5D RID: 40029
		[Token(Token = "0x4009C5D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_backButton;

		// Token: 0x04009C5E RID: 40030
		[Token(Token = "0x4009C5E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Setup;

		// Token: 0x04009C5F RID: 40031
		[Token(Token = "0x4009C5F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_NotifyFurnitureUnequiped;

		// Token: 0x04009C60 RID: 40032
		[Token(Token = "0x4009C60")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_NotifyFurnitureRegistered;

		// Token: 0x04009C61 RID: 40033
		[Token(Token = "0x4009C61")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_NotifyFurnitureUnregistered;

		// Token: 0x04009C62 RID: 40034
		[Token(Token = "0x4009C62")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_NotifyModifierChanged;

		// Token: 0x04009C63 RID: 40035
		[Token(Token = "0x4009C63")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_NotifyResetAllChanges;

		// Token: 0x04009C64 RID: 40036
		[Token(Token = "0x4009C64")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_NotifyClearAllFurnitures;

		// Token: 0x04009C65 RID: 40037
		[Token(Token = "0x4009C65")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_NotifyThemeApplied;

		// Token: 0x04009C66 RID: 40038
		[Token(Token = "0x4009C66")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_NotifyPresetApplied;

		// Token: 0x04009C67 RID: 40039
		[Token(Token = "0x4009C67")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_NotifyFurnitureSaved;

		// Token: 0x04009C68 RID: 40040
		[Token(Token = "0x4009C68")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_NotifyCameraChanged;

		// Token: 0x04009C69 RID: 40041
		[Token(Token = "0x4009C69")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_MarkFurnitureChanged;

		// Token: 0x04009C6A RID: 40042
		[Token(Token = "0x4009C6A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_MarkModifierChanged;

		// Token: 0x04009C6B RID: 40043
		[Token(Token = "0x4009C6B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_GetUIBottomMargin;

		// Token: 0x04009C6C RID: 40044
		[Token(Token = "0x4009C6C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04009C6D RID: 40045
		[Token(Token = "0x4009C6D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__InitRoomTitle;

		// Token: 0x04009C6E RID: 40046
		[Token(Token = "0x4009C6E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__OnBackPressAction;

		// Token: 0x04009C6F RID: 40047
		[Token(Token = "0x4009C6F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__ShowJudgeDialog;

		// Token: 0x04009C70 RID: 40048
		[Token(Token = "0x4009C70")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_OnTopMenuBackButtonPressed;

		// Token: 0x04009C71 RID: 40049
		[Token(Token = "0x4009C71")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_OnSaveButtonPressed;

		// Token: 0x04009C72 RID: 40050
		[Token(Token = "0x4009C72")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_OnClearButtonPressed;

		// Token: 0x04009C73 RID: 40051
		[Token(Token = "0x4009C73")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_OnResetButtonPressed;

		// Token: 0x04009C74 RID: 40052
		[Token(Token = "0x4009C74")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_OnShopPressed;

		// Token: 0x04009C75 RID: 40053
		[Token(Token = "0x4009C75")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_OnComfortPressed;

		// Token: 0x04009C76 RID: 40054
		[Token(Token = "0x4009C76")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_OnManifestBGPressed;

		// Token: 0x04009C77 RID: 40055
		[Token(Token = "0x4009C77")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_OnCeilDirectlyButtonPressed;

		// Token: 0x04009C78 RID: 40056
		[Token(Token = "0x4009C78")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_OnFloorDirectlyButtonPressed;

		// Token: 0x04009C79 RID: 40057
		[Token(Token = "0x4009C79")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_OnWallButtonPressed;

		// Token: 0x04009C7A RID: 40058
		[Token(Token = "0x4009C7A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_OnCameraResetButtonPressed;

		// Token: 0x04009C7B RID: 40059
		[Token(Token = "0x4009C7B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
