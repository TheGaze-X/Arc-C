using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003740 RID: 14144
	[Token(Token = "0x2003740")]
	public class UIDynPosJoystickHost : MonoBehaviour, IHotfixable, IPointerDownHandler, IEventSystemHandler, IKeyMoveHandler
	{
		// Token: 0x170035DA RID: 13786
		// (get) Token: 0x06016779 RID: 92025 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170035DA")]
		protected RectTransform panelJoystick
		{
			[Token(Token = "0x6016779")]
			[Address(RVA = "0xEE1850", Offset = "0xEE0450", VA = "0x180EE1850")]
			get
			{
				return null;
			}
		}

		// Token: 0x170035DB RID: 13787
		// (get) Token: 0x0601677A RID: 92026 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170035DB")]
		protected UIJoystickController joystickController
		{
			[Token(Token = "0x601677A")]
			[Address(RVA = "0xEE17F0", Offset = "0xEE03F0", VA = "0x180EE17F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170035DC RID: 13788
		// (get) Token: 0x0601677B RID: 92027 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170035DC")]
		protected UISwitchTween switchTween
		{
			[Token(Token = "0x601677B")]
			[Address(RVA = "0xEE18B0", Offset = "0xEE04B0", VA = "0x180EE18B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601677C RID: 92028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601677C")]
		[Address(RVA = "0xEE11E0", Offset = "0xEDFDE0", VA = "0x180EE11E0")]
		private void Start()
		{
		}

		// Token: 0x0601677D RID: 92029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601677D")]
		[Address(RVA = "0xEE12B0", Offset = "0xEDFEB0", VA = "0x180EE12B0")]
		private void Update()
		{
		}

		// Token: 0x0601677E RID: 92030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601677E")]
		[Address(RVA = "0xEE1410", Offset = "0xEE0010", VA = "0x180EE1410", Slot = "8")]
		protected virtual void _InitIfNot()
		{
		}

		// Token: 0x0601677F RID: 92031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601677F")]
		[Address(RVA = "0xEE0C10", Offset = "0xEDF810", VA = "0x180EE0C10")]
		private void OnDestroy()
		{
		}

		// Token: 0x06016780 RID: 92032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016780")]
		[Address(RVA = "0xEE1710", Offset = "0xEE0310", VA = "0x180EE1710")]
		private void _OnJoystickDragStop()
		{
		}

		// Token: 0x06016781 RID: 92033 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6016781")]
		[Address(RVA = "0xEE0B60", Offset = "0xEDF760", VA = "0x180EE0B60", Slot = "9")]
		protected virtual UISwitchTween InitSwitchTween(CanvasGroup canvasGroupJoystick)
		{
			return null;
		}

		// Token: 0x06016782 RID: 92034 RVA: 0x00091518 File Offset: 0x0008F718
		[Token(Token = "0x6016782")]
		[Address(RVA = "0xEE0A40", Offset = "0xEDF640", VA = "0x180EE0A40", Slot = "10")]
		protected virtual Vector2 CalculateJoystickPos(PointerEventData eventData)
		{
			return default(Vector2);
		}

		// Token: 0x06016783 RID: 92035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016783")]
		[Address(RVA = "0xEE1170", Offset = "0xEDFD70", VA = "0x180EE1170", Slot = "11")]
		protected virtual void ResetJoystick()
		{
		}

		// Token: 0x06016784 RID: 92036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016784")]
		[Address(RVA = "0xEE0E60", Offset = "0xEDFA60", VA = "0x180EE0E60", Slot = "4")]
		public void OnPointerDown(PointerEventData eventData)
		{
		}

		// Token: 0x06016785 RID: 92037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016785")]
		[Address(RVA = "0xEE0C80", Offset = "0xEDF880", VA = "0x180EE0C80", Slot = "5")]
		public void OnMove(Vector2 move)
		{
		}

		// Token: 0x06016786 RID: 92038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016786")]
		[Address(RVA = "0xEE0FD0", Offset = "0xEDFBD0", VA = "0x180EE0FD0", Slot = "6")]
		public void OnStop()
		{
		}

		// Token: 0x06016787 RID: 92039 RVA: 0x00091530 File Offset: 0x0008F730
		[Token(Token = "0x6016787")]
		[Address(RVA = "0xEE0B00", Offset = "0xEDF700", VA = "0x180EE0B00", Slot = "7")]
		public int GetInstId()
		{
			return 0;
		}

		// Token: 0x06016788 RID: 92040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016788")]
		[Address(RVA = "0xEE1790", Offset = "0xEE0390", VA = "0x180EE1790")]
		public UIDynPosJoystickHost()
		{
		}

		// Token: 0x0401B0F1 RID: 110833
		[Token(Token = "0x401B0F1")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string _joystickName;

		// Token: 0x0401B0F2 RID: 110834
		[Token(Token = "0x401B0F2")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _panelJoystick;

		// Token: 0x0401B0F3 RID: 110835
		[Token(Token = "0x401B0F3")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CanvasGroup _canvasGroupJoystick;

		// Token: 0x0401B0F4 RID: 110836
		[Token(Token = "0x401B0F4")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Graphic _graphicTarget;

		// Token: 0x0401B0F5 RID: 110837
		[Token(Token = "0x401B0F5")]
		[FieldOffset(Offset = "0x38")]
		private bool m_isInited;

		// Token: 0x0401B0F6 RID: 110838
		[Token(Token = "0x401B0F6")]
		[FieldOffset(Offset = "0x40")]
		private UISwitchTween m_switchTween;

		// Token: 0x0401B0F7 RID: 110839
		[Token(Token = "0x401B0F7")]
		[FieldOffset(Offset = "0x48")]
		private CanvasScaler m_rootCanvasScaler;

		// Token: 0x0401B0F8 RID: 110840
		[Token(Token = "0x401B0F8")]
		[FieldOffset(Offset = "0x50")]
		private UIJoystickController m_joystickController;

		// Token: 0x0401B0F9 RID: 110841
		[Token(Token = "0x401B0F9")]
		[FieldOffset(Offset = "0x58")]
		private TorappuKeyMoveEntity m_keyMoveEntity;

		// Token: 0x0401B0FA RID: 110842
		[Token(Token = "0x401B0FA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_panelJoystick;

		// Token: 0x0401B0FB RID: 110843
		[Token(Token = "0x401B0FB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_joystickController;

		// Token: 0x0401B0FC RID: 110844
		[Token(Token = "0x401B0FC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_switchTween;

		// Token: 0x0401B0FD RID: 110845
		[Token(Token = "0x401B0FD")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x0401B0FE RID: 110846
		[Token(Token = "0x401B0FE")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x0401B0FF RID: 110847
		[Token(Token = "0x401B0FF")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401B100 RID: 110848
		[Token(Token = "0x401B100")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0401B101 RID: 110849
		[Token(Token = "0x401B101")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnJoystickDragStop;

		// Token: 0x0401B102 RID: 110850
		[Token(Token = "0x401B102")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_InitSwitchTween;

		// Token: 0x0401B103 RID: 110851
		[Token(Token = "0x401B103")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_CalculateJoystickPos;

		// Token: 0x0401B104 RID: 110852
		[Token(Token = "0x401B104")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_ResetJoystick;

		// Token: 0x0401B105 RID: 110853
		[Token(Token = "0x401B105")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnPointerDown;

		// Token: 0x0401B106 RID: 110854
		[Token(Token = "0x401B106")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnMove;

		// Token: 0x0401B107 RID: 110855
		[Token(Token = "0x401B107")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_OnStop;

		// Token: 0x0401B108 RID: 110856
		[Token(Token = "0x401B108")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_GetInstId;

		// Token: 0x0401B109 RID: 110857
		[Token(Token = "0x401B109")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
