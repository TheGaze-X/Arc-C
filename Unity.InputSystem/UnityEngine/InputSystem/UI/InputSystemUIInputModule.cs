using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem.Utilities;
using UnityEngine.Serialization;

namespace UnityEngine.InputSystem.UI
{
	// Token: 0x02000112 RID: 274
	[Token(Token = "0x2000112")]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.inputsystem@1.7/manual/UISupport.html#setting-up-ui-input")]
	public class InputSystemUIInputModule : BaseInputModule
	{
		// Token: 0x17000363 RID: 867
		// (get) Token: 0x06000CE7 RID: 3303 RVA: 0x000065B8 File Offset: 0x000047B8
		// (set) Token: 0x06000CE8 RID: 3304 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000363")]
		public bool deselectOnBackgroundClick
		{
			[Token(Token = "0x6000CE7")]
			[Address(RVA = "0x371A210", Offset = "0x3718E10", VA = "0x18371A210")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000CE8")]
			[Address(RVA = "0x371A3B0", Offset = "0x3718FB0", VA = "0x18371A3B0")]
			set
			{
			}
		}

		// Token: 0x17000364 RID: 868
		// (get) Token: 0x06000CE9 RID: 3305 RVA: 0x000065D0 File Offset: 0x000047D0
		// (set) Token: 0x06000CEA RID: 3306 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000364")]
		public UIPointerBehavior pointerBehavior
		{
			[Token(Token = "0x6000CE9")]
			[Address(RVA = "0x56C4B00", Offset = "0x56C3700", VA = "0x1856C4B00")]
			get
			{
				return UIPointerBehavior.SingleMouseOrPenButMultiTouchAndTrack;
			}
			[Token(Token = "0x6000CEA")]
			[Address(RVA = "0x56C5420", Offset = "0x56C4020", VA = "0x1856C5420")]
			set
			{
			}
		}

		// Token: 0x17000365 RID: 869
		// (get) Token: 0x06000CEB RID: 3307 RVA: 0x000065E8 File Offset: 0x000047E8
		// (set) Token: 0x06000CEC RID: 3308 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000365")]
		public InputSystemUIInputModule.CursorLockBehavior cursorLockBehavior
		{
			[Token(Token = "0x6000CEB")]
			[Address(RVA = "0x24CF740", Offset = "0x24CE340", VA = "0x1824CF740")]
			get
			{
				return InputSystemUIInputModule.CursorLockBehavior.OutsideScreen;
			}
			[Token(Token = "0x6000CEC")]
			[Address(RVA = "0x56C5300", Offset = "0x56C3F00", VA = "0x1856C5300")]
			set
			{
			}
		}

		// Token: 0x17000366 RID: 870
		// (get) Token: 0x06000CED RID: 3309 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000CEE RID: 3310 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000366")]
		internal GameObject localMultiPlayerRoot
		{
			[Token(Token = "0x6000CED")]
			[Address(RVA = "0x56C4AF0", Offset = "0x56C36F0", VA = "0x1856C4AF0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000CEE")]
			[Address(RVA = "0x56C5350", Offset = "0x56C3F50", VA = "0x1856C5350")]
			set
			{
			}
		}

		// Token: 0x06000CEF RID: 3311 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CEF")]
		[Address(RVA = "0x56BDCA0", Offset = "0x56BC8A0", VA = "0x1856BDCA0", Slot = "24")]
		public override void ActivateModule()
		{
		}

		// Token: 0x06000CF0 RID: 3312 RVA: 0x00006600 File Offset: 0x00004800
		[Token(Token = "0x6000CF0")]
		[Address(RVA = "0x56C0070", Offset = "0x56BEC70", VA = "0x1856C0070", Slot = "20")]
		public override bool IsPointerOverGameObject(int pointerOrTouchId)
		{
			return default(bool);
		}

		// Token: 0x06000CF1 RID: 3313 RVA: 0x00006618 File Offset: 0x00004818
		[Token(Token = "0x6000CF1")]
		[Address(RVA = "0x56BEB10", Offset = "0x56BD710", VA = "0x1856BEB10")]
		public RaycastResult GetLastRaycastResult(int pointerOrTouchId)
		{
			return default(RaycastResult);
		}

		// Token: 0x06000CF2 RID: 3314 RVA: 0x00006630 File Offset: 0x00004830
		[Token(Token = "0x6000CF2")]
		[Address(RVA = "0x56C0CF0", Offset = "0x56BF8F0", VA = "0x1856C0CF0")]
		private RaycastResult PerformRaycast(ExtendedPointerEventData eventData)
		{
			return default(RaycastResult);
		}

		// Token: 0x06000CF3 RID: 3315 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CF3")]
		[Address(RVA = "0x56C2B60", Offset = "0x56C1760", VA = "0x1856C2B60")]
		private void ProcessPointer(ref PointerModel state)
		{
		}

		// Token: 0x06000CF4 RID: 3316 RVA: 0x00006648 File Offset: 0x00004848
		[Token(Token = "0x6000CF4")]
		[Address(RVA = "0x56C1040", Offset = "0x56BFC40", VA = "0x1856C1040")]
		private bool PointerShouldIgnoreTransform(Transform t)
		{
			return default(bool);
		}

		// Token: 0x06000CF5 RID: 3317 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CF5")]
		[Address(RVA = "0x56C2330", Offset = "0x56C0F30", VA = "0x1856C2330")]
		private void ProcessPointerMovement(ref PointerModel pointer, ExtendedPointerEventData eventData)
		{
		}

		// Token: 0x06000CF6 RID: 3318 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CF6")]
		[Address(RVA = "0x56C2390", Offset = "0x56C0F90", VA = "0x1856C2390")]
		private void ProcessPointerMovement(ExtendedPointerEventData eventData, GameObject currentPointerTarget)
		{
		}

		// Token: 0x06000CF7 RID: 3319 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CF7")]
		[Address(RVA = "0x56C1AD0", Offset = "0x56C06D0", VA = "0x1856C1AD0")]
		private void ProcessPointerButton(ref PointerModel.ButtonState button, PointerEventData eventData)
		{
		}

		// Token: 0x06000CF8 RID: 3320 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CF8")]
		[Address(RVA = "0x56C17D0", Offset = "0x56C03D0", VA = "0x1856C17D0")]
		private void ProcessPointerButtonDrag(ref PointerModel.ButtonState button, ExtendedPointerEventData eventData)
		{
		}

		// Token: 0x06000CF9 RID: 3321 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CF9")]
		[Address(RVA = "0x56C2A20", Offset = "0x56C1620", VA = "0x1856C2A20")]
		private static void ProcessPointerScroll(ref PointerModel pointer, PointerEventData eventData)
		{
		}

		// Token: 0x06000CFA RID: 3322 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000CFA")]
		[Address(RVA = "0x56C1160", Offset = "0x56BFD60", VA = "0x1856C1160")]
		internal void ProcessNavigation(ref NavigationModel navigationState)
		{
		}

		// Token: 0x06000CFB RID: 3323 RVA: 0x00006660 File Offset: 0x00004860
		[Token(Token = "0x6000CFB")]
		[Address(RVA = "0x56BFE80", Offset = "0x56BEA80", VA = "0x1856BFE80")]
		private bool IsMoveAllowed(AxisEventData eventData)
		{
			return default(bool);
		}

		// Token: 0x17000367 RID: 871
		// (get) Token: 0x06000CFC RID: 3324 RVA: 0x00006678 File Offset: 0x00004878
		// (set) Token: 0x06000CFD RID: 3325 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000367")]
		public float moveRepeatDelay
		{
			[Token(Token = "0x6000CFC")]
			[Address(RVA = "0x1692360", Offset = "0x1690F60", VA = "0x181692360")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000CFD")]
			[Address(RVA = "0x1692840", Offset = "0x1691440", VA = "0x181692840")]
			set
			{
			}
		}

		// Token: 0x17000368 RID: 872
		// (get) Token: 0x06000CFE RID: 3326 RVA: 0x00006690 File Offset: 0x00004890
		// (set) Token: 0x06000CFF RID: 3327 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000368")]
		public float moveRepeatRate
		{
			[Token(Token = "0x6000CFE")]
			[Address(RVA = "0x4E4DA40", Offset = "0x4E4C640", VA = "0x184E4DA40")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000CFF")]
			[Address(RVA = "0x4E4DF20", Offset = "0x4E4CB20", VA = "0x184E4DF20")]
			set
			{
			}
		}

		// Token: 0x17000369 RID: 873
		// (get) Token: 0x06000D00 RID: 3328 RVA: 0x000066A8 File Offset: 0x000048A8
		[Token(Token = "0x17000369")]
		private bool explictlyIgnoreFocus
		{
			[Token(Token = "0x6000D00")]
			[Address(RVA = "0x56C4A90", Offset = "0x56C3690", VA = "0x1856C4A90")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700036A RID: 874
		// (get) Token: 0x06000D01 RID: 3329 RVA: 0x000066C0 File Offset: 0x000048C0
		[Token(Token = "0x1700036A")]
		private bool shouldIgnoreFocus
		{
			[Token(Token = "0x6000D01")]
			[Address(RVA = "0x56C4B10", Offset = "0x56C3710", VA = "0x1856C4B10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700036B RID: 875
		// (get) Token: 0x06000D02 RID: 3330 RVA: 0x000066D8 File Offset: 0x000048D8
		// (set) Token: 0x06000D03 RID: 3331 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700036B")]
		[Obsolete("'repeatRate' has been obsoleted; use 'moveRepeatRate' instead. (UnityUpgradable) -> moveRepeatRate", false)]
		public float repeatRate
		{
			[Token(Token = "0x6000D02")]
			[Address(RVA = "0x4E4DA40", Offset = "0x4E4C640", VA = "0x184E4DA40")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000D03")]
			[Address(RVA = "0x4E4DF20", Offset = "0x4E4CB20", VA = "0x184E4DF20")]
			set
			{
			}
		}

		// Token: 0x1700036C RID: 876
		// (get) Token: 0x06000D04 RID: 3332 RVA: 0x000066F0 File Offset: 0x000048F0
		// (set) Token: 0x06000D05 RID: 3333 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700036C")]
		[Obsolete("'repeatDelay' has been obsoleted; use 'moveRepeatDelay' instead. (UnityUpgradable) -> moveRepeatDelay", false)]
		public float repeatDelay
		{
			[Token(Token = "0x6000D04")]
			[Address(RVA = "0x1692360", Offset = "0x1690F60", VA = "0x181692360")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000D05")]
			[Address(RVA = "0x1692840", Offset = "0x1691440", VA = "0x181692840")]
			set
			{
			}
		}

		// Token: 0x1700036D RID: 877
		// (get) Token: 0x06000D06 RID: 3334 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000D07 RID: 3335 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700036D")]
		public Transform xrTrackingOrigin
		{
			[Token(Token = "0x6000D06")]
			[Address(RVA = "0x7CEE10", Offset = "0x7CDA10", VA = "0x1807CEE10")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000D07")]
			[Address(RVA = "0x18480D0", Offset = "0x1846CD0", VA = "0x1818480D0")]
			set
			{
			}
		}

		// Token: 0x1700036E RID: 878
		// (get) Token: 0x06000D08 RID: 3336 RVA: 0x00006708 File Offset: 0x00004908
		// (set) Token: 0x06000D09 RID: 3337 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700036E")]
		public float trackedDeviceDragThresholdMultiplier
		{
			[Token(Token = "0x6000D08")]
			[Address(RVA = "0x4E4DA50", Offset = "0x4E4C650", VA = "0x184E4DA50")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000D09")]
			[Address(RVA = "0x4E4DF30", Offset = "0x4E4CB30", VA = "0x184E4DF30")]
			set
			{
			}
		}

		// Token: 0x06000D0A RID: 3338 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D0A")]
		[Address(RVA = "0x56C42C0", Offset = "0x56C2EC0", VA = "0x1856C42C0")]
		private void SwapAction(ref InputActionReference property, InputActionReference newValue, bool actionsHooked, Action<InputAction.CallbackContext> actionCallback)
		{
		}

		// Token: 0x1700036F RID: 879
		// (get) Token: 0x06000D0B RID: 3339 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000D0C RID: 3340 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700036F")]
		public InputActionReference point
		{
			[Token(Token = "0x6000D0B")]
			[Address(RVA = "0xEB4B80", Offset = "0xEB3780", VA = "0x180EB4B80")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000D0C")]
			[Address(RVA = "0x56C53E0", Offset = "0x56C3FE0", VA = "0x1856C53E0")]
			set
			{
			}
		}

		// Token: 0x17000370 RID: 880
		// (get) Token: 0x06000D0D RID: 3341 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000D0E RID: 3342 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000370")]
		public InputActionReference scrollWheel
		{
			[Token(Token = "0x6000D0D")]
			[Address(RVA = "0x4E8AF0", Offset = "0x4E76F0", VA = "0x1804E8AF0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000D0E")]
			[Address(RVA = "0x56C5470", Offset = "0x56C4070", VA = "0x1856C5470")]
			set
			{
			}
		}

		// Token: 0x17000371 RID: 881
		// (get) Token: 0x06000D0F RID: 3343 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000D10 RID: 3344 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000371")]
		public InputActionReference leftClick
		{
			[Token(Token = "0x6000D0F")]
			[Address(RVA = "0xF93800", Offset = "0xF92400", VA = "0x180F93800")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000D10")]
			[Address(RVA = "0x56C5310", Offset = "0x56C3F10", VA = "0x1856C5310")]
			set
			{
			}
		}

		// Token: 0x17000372 RID: 882
		// (get) Token: 0x06000D11 RID: 3345 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000D12 RID: 3346 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000372")]
		public InputActionReference middleClick
		{
			[Token(Token = "0x6000D11")]
			[Address(RVA = "0x4FB2F0", Offset = "0x4F9EF0", VA = "0x1804FB2F0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000D12")]
			[Address(RVA = "0x56C5360", Offset = "0x56C3F60", VA = "0x1856C5360")]
			set
			{
			}
		}

		// Token: 0x17000373 RID: 883
		// (get) Token: 0x06000D13 RID: 3347 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000D14 RID: 3348 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000373")]
		public InputActionReference rightClick
		{
			[Token(Token = "0x6000D13")]
			[Address(RVA = "0x4E8B00", Offset = "0x4E7700", VA = "0x1804E8B00")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000D14")]
			[Address(RVA = "0x56C5430", Offset = "0x56C4030", VA = "0x1856C5430")]
			set
			{
			}
		}

		// Token: 0x17000374 RID: 884
		// (get) Token: 0x06000D15 RID: 3349 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000D16 RID: 3350 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000374")]
		public InputActionReference move
		{
			[Token(Token = "0x6000D15")]
			[Address(RVA = "0xEB4B50", Offset = "0xEB3750", VA = "0x180EB4B50")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000D16")]
			[Address(RVA = "0x56C53A0", Offset = "0x56C3FA0", VA = "0x1856C53A0")]
			set
			{
			}
		}

		// Token: 0x17000375 RID: 885
		// (get) Token: 0x06000D17 RID: 3351 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000D18 RID: 3352 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000375")]
		public InputActionReference submit
		{
			[Token(Token = "0x6000D17")]
			[Address(RVA = "0xEB4B60", Offset = "0xEB3760", VA = "0x180EB4B60")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000D18")]
			[Address(RVA = "0x56C54B0", Offset = "0x56C40B0", VA = "0x1856C54B0")]
			set
			{
			}
		}

		// Token: 0x17000376 RID: 886
		// (get) Token: 0x06000D19 RID: 3353 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000D1A RID: 3354 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000376")]
		public InputActionReference cancel
		{
			[Token(Token = "0x6000D19")]
			[Address(RVA = "0x789270", Offset = "0x787E70", VA = "0x180789270")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000D1A")]
			[Address(RVA = "0x56C52D0", Offset = "0x56C3ED0", VA = "0x1856C52D0")]
			set
			{
			}
		}

		// Token: 0x17000377 RID: 887
		// (get) Token: 0x06000D1B RID: 3355 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000D1C RID: 3356 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000377")]
		public InputActionReference trackedDeviceOrientation
		{
			[Token(Token = "0x6000D1B")]
			[Address(RVA = "0x20BBCF0", Offset = "0x20BA8F0", VA = "0x1820BBCF0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000D1C")]
			[Address(RVA = "0x56C54E0", Offset = "0x56C40E0", VA = "0x1856C54E0")]
			set
			{
			}
		}

		// Token: 0x17000378 RID: 888
		// (get) Token: 0x06000D1D RID: 3357 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000D1E RID: 3358 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000378")]
		public InputActionReference trackedDevicePosition
		{
			[Token(Token = "0x6000D1D")]
			[Address(RVA = "0x22F8850", Offset = "0x22F7450", VA = "0x1822F8850")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000D1E")]
			[Address(RVA = "0x56C5520", Offset = "0x56C4120", VA = "0x1856C5520")]
			set
			{
			}
		}

		// Token: 0x06000D1F RID: 3359 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D1F")]
		[Address(RVA = "0x56BE000", Offset = "0x56BCC00", VA = "0x1856BE000")]
		public void AssignDefaultActions()
		{
		}

		// Token: 0x06000D20 RID: 3360 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D20")]
		[Address(RVA = "0x56C4740", Offset = "0x56C3340", VA = "0x1856C4740")]
		public void UnassignActions()
		{
		}

		// Token: 0x17000379 RID: 889
		// (get) Token: 0x06000D21 RID: 3361 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000D22 RID: 3362 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000379")]
		[Obsolete("'trackedDeviceSelect' has been obsoleted; use 'leftClick' instead.", true)]
		public InputActionReference trackedDeviceSelect
		{
			[Token(Token = "0x6000D21")]
			[Address(RVA = "0x56C4BC0", Offset = "0x56C37C0", VA = "0x1856C4BC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000D22")]
			[Address(RVA = "0x56C5560", Offset = "0x56C4160", VA = "0x1856C5560")]
			set
			{
			}
		}

		// Token: 0x06000D23 RID: 3363 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D23")]
		[Address(RVA = "0x56BE390", Offset = "0x56BCF90", VA = "0x1856BE390", Slot = "4")]
		protected override void Awake()
		{
		}

		// Token: 0x06000D24 RID: 3364 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D24")]
		[Address(RVA = "0x56C01D0", Offset = "0x56BEDD0", VA = "0x1856C01D0", Slot = "8")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x06000D25 RID: 3365 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D25")]
		[Address(RVA = "0x56C0370", Offset = "0x56BEF70", VA = "0x1856C0370", Slot = "5")]
		protected override void OnEnable()
		{
		}

		// Token: 0x06000D26 RID: 3366 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D26")]
		[Address(RVA = "0x56C0210", Offset = "0x56BEE10", VA = "0x1856C0210", Slot = "7")]
		protected override void OnDisable()
		{
		}

		// Token: 0x06000D27 RID: 3367 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D27")]
		[Address(RVA = "0x56C3A40", Offset = "0x56C2640", VA = "0x1856C3A40")]
		private void ResetPointers()
		{
		}

		// Token: 0x06000D28 RID: 3368 RVA: 0x00006720 File Offset: 0x00004920
		[Token(Token = "0x6000D28")]
		[Address(RVA = "0x56BF7F0", Offset = "0x56BE3F0", VA = "0x1856BF7F0")]
		private bool HasNoActions()
		{
			return default(bool);
		}

		// Token: 0x06000D29 RID: 3369 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D29")]
		[Address(RVA = "0x56BE630", Offset = "0x56BD230", VA = "0x1856BE630")]
		private void EnableAllActions()
		{
		}

		// Token: 0x06000D2A RID: 3370 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D2A")]
		[Address(RVA = "0x56BE550", Offset = "0x56BD150", VA = "0x1856BE550")]
		private void DisableAllActions()
		{
		}

		// Token: 0x06000D2B RID: 3371 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D2B")]
		[Address(RVA = "0x56BE6F0", Offset = "0x56BD2F0", VA = "0x1856BE6F0")]
		private void EnableInputAction(InputActionReference inputActionReference)
		{
		}

		// Token: 0x06000D2C RID: 3372 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D2C")]
		[Address(RVA = "0x56C4590", Offset = "0x56C3190", VA = "0x1856C4590")]
		private void TryDisableInputAction(InputActionReference inputActionReference, bool isComponentDisabling = false)
		{
		}

		// Token: 0x06000D2D RID: 3373 RVA: 0x00006738 File Offset: 0x00004938
		[Token(Token = "0x6000D2D")]
		[Address(RVA = "0x56BECD0", Offset = "0x56BD8D0", VA = "0x1856BECD0")]
		private int GetPointerStateIndexFor(int pointerOrTouchId)
		{
			return 0;
		}

		// Token: 0x06000D2E RID: 3374 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000D2E")]
		[Address(RVA = "0x56BEBE0", Offset = "0x56BD7E0", VA = "0x1856BEBE0")]
		private ref PointerModel GetPointerStateForIndex(int index)
		{
			return null;
		}

		// Token: 0x06000D2F RID: 3375 RVA: 0x00006750 File Offset: 0x00004950
		[Token(Token = "0x6000D2F")]
		[Address(RVA = "0x56BEA50", Offset = "0x56BD650", VA = "0x1856BEA50")]
		private int GetDisplayIndexFor(InputControl control)
		{
			return 0;
		}

		// Token: 0x06000D30 RID: 3376 RVA: 0x00006768 File Offset: 0x00004968
		[Token(Token = "0x6000D30")]
		[Address(RVA = "0x56BEC30", Offset = "0x56BD830", VA = "0x1856BEC30")]
		private int GetPointerStateIndexFor(ref InputAction.CallbackContext context)
		{
			return 0;
		}

		// Token: 0x06000D31 RID: 3377 RVA: 0x00006780 File Offset: 0x00004980
		[Token(Token = "0x6000D31")]
		[Address(RVA = "0x56BEE20", Offset = "0x56BDA20", VA = "0x1856BEE20")]
		private int GetPointerStateIndexFor(InputControl control, bool createIfNotExists = true)
		{
			return 0;
		}

		// Token: 0x06000D32 RID: 3378 RVA: 0x00006798 File Offset: 0x00004998
		[Token(Token = "0x6000D32")]
		[Address(RVA = "0x56BDD80", Offset = "0x56BC980", VA = "0x1856BDD80")]
		private int AllocatePointer(int pointerId, int displayIndex, int touchId, UIPointerType pointerType, InputControl control, InputDevice device, [Optional] InputControl touchControl)
		{
			return 0;
		}

		// Token: 0x06000D33 RID: 3379 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D33")]
		[Address(RVA = "0x56C3B50", Offset = "0x56C2750", VA = "0x1856C3B50")]
		private void SendPointerExitEventsAndRemovePointer(int index)
		{
		}

		// Token: 0x06000D34 RID: 3380 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D34")]
		[Address(RVA = "0x56C37E0", Offset = "0x56C23E0", VA = "0x1856C37E0")]
		private void RemovePointerAtIndex(int index)
		{
		}

		// Token: 0x06000D35 RID: 3381 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D35")]
		[Address(RVA = "0x56C3660", Offset = "0x56C2260", VA = "0x1856C3660")]
		private void PurgeStalePointers()
		{
		}

		// Token: 0x06000D36 RID: 3382 RVA: 0x000067B0 File Offset: 0x000049B0
		[Token(Token = "0x6000D36")]
		[Address(RVA = "0x56BF960", Offset = "0x56BE560", VA = "0x1856BF960")]
		private static bool HaveControlForDevice(InputDevice device, InputActionReference actionReference)
		{
			return default(bool);
		}

		// Token: 0x06000D37 RID: 3383 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D37")]
		[Address(RVA = "0x56C07B0", Offset = "0x56BF3B0", VA = "0x1856C07B0")]
		private void OnPointCallback(InputAction.CallbackContext context)
		{
		}

		// Token: 0x06000D38 RID: 3384 RVA: 0x000067C8 File Offset: 0x000049C8
		[Token(Token = "0x6000D38")]
		[Address(RVA = "0x56BFD60", Offset = "0x56BE960", VA = "0x1856BFD60")]
		private bool IgnoreNextClick(ref InputAction.CallbackContext context, bool wasPressed)
		{
			return default(bool);
		}

		// Token: 0x06000D39 RID: 3385 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D39")]
		[Address(RVA = "0x56C0530", Offset = "0x56BF130", VA = "0x1856C0530")]
		private void OnLeftClickCallback(InputAction.CallbackContext context)
		{
		}

		// Token: 0x06000D3A RID: 3386 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D3A")]
		[Address(RVA = "0x56C08A0", Offset = "0x56BF4A0", VA = "0x1856C08A0")]
		private void OnRightClickCallback(InputAction.CallbackContext context)
		{
		}

		// Token: 0x06000D3B RID: 3387 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D3B")]
		[Address(RVA = "0x56C0630", Offset = "0x56BF230", VA = "0x1856C0630")]
		private void OnMiddleClickCallback(InputAction.CallbackContext context)
		{
		}

		// Token: 0x06000D3C RID: 3388 RVA: 0x000067E0 File Offset: 0x000049E0
		[Token(Token = "0x6000D3C")]
		[Address(RVA = "0x56BE3F0", Offset = "0x56BCFF0", VA = "0x1856BE3F0")]
		private bool CheckForRemovedDevice(ref InputAction.CallbackContext context)
		{
			return default(bool);
		}

		// Token: 0x06000D3D RID: 3389 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D3D")]
		[Address(RVA = "0x56C09B0", Offset = "0x56BF5B0", VA = "0x1856C09B0")]
		private void OnScrollCallback(InputAction.CallbackContext context)
		{
		}

		// Token: 0x06000D3E RID: 3390 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D3E")]
		[Address(RVA = "0x56C0740", Offset = "0x56BF340", VA = "0x1856C0740")]
		private void OnMoveCallback(InputAction.CallbackContext context)
		{
		}

		// Token: 0x06000D3F RID: 3391 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D3F")]
		[Address(RVA = "0x56C0AC0", Offset = "0x56BF6C0", VA = "0x1856C0AC0")]
		private void OnTrackedDeviceOrientationCallback(InputAction.CallbackContext context)
		{
		}

		// Token: 0x06000D40 RID: 3392 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D40")]
		[Address(RVA = "0x56C0BD0", Offset = "0x56BF7D0", VA = "0x1856C0BD0")]
		private void OnTrackedDevicePositionCallback(InputAction.CallbackContext context)
		{
		}

		// Token: 0x06000D41 RID: 3393 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D41")]
		[Address(RVA = "0x56C01C0", Offset = "0x56BEDC0", VA = "0x1856C01C0")]
		private void OnControlsChanged(object obj)
		{
		}

		// Token: 0x06000D42 RID: 3394 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D42")]
		[Address(RVA = "0x56BE890", Offset = "0x56BD490", VA = "0x1856BE890")]
		private void FilterPointerStatesByType()
		{
		}

		// Token: 0x06000D43 RID: 3395 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D43")]
		[Address(RVA = "0x56C32E0", Offset = "0x56C1EE0", VA = "0x1856C32E0", Slot = "17")]
		public override void Process()
		{
		}

		// Token: 0x06000D44 RID: 3396 RVA: 0x000067F8 File Offset: 0x000049F8
		[Token(Token = "0x6000D44")]
		[Address(RVA = "0x56BE460", Offset = "0x56BD060", VA = "0x1856BE460", Slot = "27")]
		public override int ConvertUIToolkitPointerId(PointerEventData sourcePointerData)
		{
			return 0;
		}

		// Token: 0x06000D45 RID: 3397 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D45")]
		[Address(RVA = "0x56BFA30", Offset = "0x56BE630", VA = "0x1856BFA30")]
		private void HookActions()
		{
		}

		// Token: 0x06000D46 RID: 3398 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D46")]
		[Address(RVA = "0x56C4910", Offset = "0x56C3510", VA = "0x1856C4910")]
		private void UnhookActions()
		{
		}

		// Token: 0x06000D47 RID: 3399 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D47")]
		[Address(RVA = "0x56C3D10", Offset = "0x56C2910", VA = "0x1856C3D10")]
		private void SetActionCallbacks(bool install)
		{
		}

		// Token: 0x06000D48 RID: 3400 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D48")]
		[Address(RVA = "0x56C3C30", Offset = "0x56C2830", VA = "0x1856C3C30")]
		private static void SetActionCallback(InputActionReference actionReference, Action<InputAction.CallbackContext> callback, bool install)
		{
		}

		// Token: 0x06000D49 RID: 3401 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000D49")]
		[Address(RVA = "0x56C4930", Offset = "0x56C3530", VA = "0x1856C4930")]
		private InputActionReference UpdateReferenceForNewAsset(InputActionReference actionReference)
		{
			return null;
		}

		// Token: 0x1700037A RID: 890
		// (get) Token: 0x06000D4A RID: 3402 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000D4B RID: 3403 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700037A")]
		public InputActionAsset actionsAsset
		{
			[Token(Token = "0x6000D4A")]
			[Address(RVA = "0xEB4B70", Offset = "0xEB3770", VA = "0x180EB4B70")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000D4B")]
			[Address(RVA = "0x56C4C10", Offset = "0x56C3810", VA = "0x1856C4C10")]
			set
			{
			}
		}

		// Token: 0x06000D4C RID: 3404 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D4C")]
		[Address(RVA = "0x56C4A60", Offset = "0x56C3660", VA = "0x1856C4A60")]
		public InputSystemUIInputModule()
		{
		}

		// Token: 0x04000618 RID: 1560
		[Token(Token = "0x4000618")]
		private const float kClickSpeed = 0.3f;

		// Token: 0x04000619 RID: 1561
		[Token(Token = "0x4000619")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[Tooltip("The Initial delay (in seconds) between an initial move action and a repeated move action.")]
		[FormerlySerializedAs("m_RepeatDelay")]
		[SerializeField]
		private float m_MoveRepeatDelay;

		// Token: 0x0400061A RID: 1562
		[Token(Token = "0x400061A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[SerializeField]
		[Tooltip("The speed (in seconds) that the move action repeats itself once repeating (max 1 per frame).")]
		[FormerlySerializedAs("m_RepeatRate")]
		private float m_MoveRepeatRate;

		// Token: 0x0400061B RID: 1563
		[Token(Token = "0x400061B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[Tooltip("Scales the Eventsystem.DragThreshold, for tracked devices, to make selection easier.")]
		private float m_TrackedDeviceDragThresholdMultiplier;

		// Token: 0x0400061C RID: 1564
		[Token(Token = "0x400061C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[Tooltip("Transform representing the real world origin for tracking devices. When using the XR Interaction Toolkit, this should be pointing to the XR Rig's Transform.")]
		[SerializeField]
		private Transform m_XRTrackingOrigin;

		// Token: 0x0400061D RID: 1565
		[Token(Token = "0x400061D")]
		internal const float kPixelPerLine = 20f;

		// Token: 0x0400061E RID: 1566
		[Token(Token = "0x400061E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[HideInInspector]
		[SerializeField]
		private InputActionAsset m_ActionsAsset;

		// Token: 0x0400061F RID: 1567
		[Token(Token = "0x400061F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		[HideInInspector]
		private InputActionReference m_PointAction;

		// Token: 0x04000620 RID: 1568
		[Token(Token = "0x4000620")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		[HideInInspector]
		private InputActionReference m_MoveAction;

		// Token: 0x04000621 RID: 1569
		[Token(Token = "0x4000621")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		[HideInInspector]
		private InputActionReference m_SubmitAction;

		// Token: 0x04000622 RID: 1570
		[Token(Token = "0x4000622")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[HideInInspector]
		[SerializeField]
		private InputActionReference m_CancelAction;

		// Token: 0x04000623 RID: 1571
		[Token(Token = "0x4000623")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[HideInInspector]
		[SerializeField]
		private InputActionReference m_LeftClickAction;

		// Token: 0x04000624 RID: 1572
		[Token(Token = "0x4000624")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[HideInInspector]
		private InputActionReference m_MiddleClickAction;

		// Token: 0x04000625 RID: 1573
		[Token(Token = "0x4000625")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[HideInInspector]
		private InputActionReference m_RightClickAction;

		// Token: 0x04000626 RID: 1574
		[Token(Token = "0x4000626")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[HideInInspector]
		private InputActionReference m_ScrollWheelAction;

		// Token: 0x04000627 RID: 1575
		[Token(Token = "0x4000627")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[HideInInspector]
		private InputActionReference m_TrackedDevicePositionAction;

		// Token: 0x04000628 RID: 1576
		[Token(Token = "0x4000628")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[HideInInspector]
		[SerializeField]
		private InputActionReference m_TrackedDeviceOrientationAction;

		// Token: 0x04000629 RID: 1577
		[Token(Token = "0x4000629")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private bool m_DeselectOnBackgroundClick;

		// Token: 0x0400062A RID: 1578
		[Token(Token = "0x400062A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
		[SerializeField]
		private UIPointerBehavior m_PointerBehavior;

		// Token: 0x0400062B RID: 1579
		[Token(Token = "0x400062B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[SerializeField]
		[HideInInspector]
		internal InputSystemUIInputModule.CursorLockBehavior m_CursorLockBehavior;

		// Token: 0x0400062C RID: 1580
		[Token(Token = "0x400062C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Dictionary<InputAction, InputSystemUIInputModule.InputActionReferenceState> s_InputActionReferenceCounts;

		// Token: 0x0400062D RID: 1581
		[Token(Token = "0x400062D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
		[NonSerialized]
		private bool m_ActionsHooked;

		// Token: 0x0400062E RID: 1582
		[Token(Token = "0x400062E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD5")]
		[NonSerialized]
		private bool m_NeedToPurgeStalePointers;

		// Token: 0x0400062F RID: 1583
		[Token(Token = "0x400062F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private Action<InputAction.CallbackContext> m_OnPointDelegate;

		// Token: 0x04000630 RID: 1584
		[Token(Token = "0x4000630")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private Action<InputAction.CallbackContext> m_OnMoveDelegate;

		// Token: 0x04000631 RID: 1585
		[Token(Token = "0x4000631")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Action<InputAction.CallbackContext> m_OnLeftClickDelegate;

		// Token: 0x04000632 RID: 1586
		[Token(Token = "0x4000632")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private Action<InputAction.CallbackContext> m_OnRightClickDelegate;

		// Token: 0x04000633 RID: 1587
		[Token(Token = "0x4000633")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private Action<InputAction.CallbackContext> m_OnMiddleClickDelegate;

		// Token: 0x04000634 RID: 1588
		[Token(Token = "0x4000634")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private Action<InputAction.CallbackContext> m_OnScrollWheelDelegate;

		// Token: 0x04000635 RID: 1589
		[Token(Token = "0x4000635")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Action<InputAction.CallbackContext> m_OnTrackedDevicePositionDelegate;

		// Token: 0x04000636 RID: 1590
		[Token(Token = "0x4000636")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private Action<InputAction.CallbackContext> m_OnTrackedDeviceOrientationDelegate;

		// Token: 0x04000637 RID: 1591
		[Token(Token = "0x4000637")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Action<object> m_OnControlsChangedDelegate;

		// Token: 0x04000638 RID: 1592
		[Token(Token = "0x4000638")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		[NonSerialized]
		private int m_CurrentPointerId;

		// Token: 0x04000639 RID: 1593
		[Token(Token = "0x4000639")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x124")]
		[NonSerialized]
		private int m_CurrentPointerIndex;

		// Token: 0x0400063A RID: 1594
		[Token(Token = "0x400063A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		[NonSerialized]
		internal UIPointerType m_CurrentPointerType;

		// Token: 0x0400063B RID: 1595
		[Token(Token = "0x400063B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		internal InlinedArray<int> m_PointerIds;

		// Token: 0x0400063C RID: 1596
		[Token(Token = "0x400063C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		internal InlinedArray<InputControl> m_PointerTouchControls;

		// Token: 0x0400063D RID: 1597
		[Token(Token = "0x400063D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		internal InlinedArray<PointerModel> m_PointerStates;

		// Token: 0x0400063E RID: 1598
		[Token(Token = "0x400063E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x388")]
		private NavigationModel m_NavigationState;

		// Token: 0x0400063F RID: 1599
		[Token(Token = "0x400063F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3A8")]
		[NonSerialized]
		private GameObject m_LocalMultiPlayerRoot;

		// Token: 0x02000113 RID: 275
		[Token(Token = "0x2000113")]
		private struct InputActionReferenceState
		{
			// Token: 0x04000640 RID: 1600
			[Token(Token = "0x4000640")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int refCount;

			// Token: 0x04000641 RID: 1601
			[Token(Token = "0x4000641")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public bool enabledByInputModule;
		}

		// Token: 0x02000114 RID: 276
		[Token(Token = "0x2000114")]
		public enum CursorLockBehavior
		{
			// Token: 0x04000643 RID: 1603
			[Token(Token = "0x4000643")]
			OutsideScreen,
			// Token: 0x04000644 RID: 1604
			[Token(Token = "0x4000644")]
			ScreenCenter
		}
	}
}
