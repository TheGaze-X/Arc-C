using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.CharWord;
using UnityEngine;
using XLua;

namespace Torappu.UI.HotUpdate
{
	// Token: 0x02004AA0 RID: 19104
	[Token(Token = "0x2004AA0")]
	public class HotUpdateVoicePrefView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601CB32 RID: 117554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CB32")]
		[Address(RVA = "0x1628DC0", Offset = "0x16279C0", VA = "0x181628DC0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601CB33 RID: 117555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CB33")]
		[Address(RVA = "0x1629020", Offset = "0x1627C20", VA = "0x181629020")]
		private void _Show()
		{
		}

		// Token: 0x0601CB34 RID: 117556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CB34")]
		[Address(RVA = "0x1628D30", Offset = "0x1627930", VA = "0x181628D30")]
		private void _Hide()
		{
		}

		// Token: 0x0601CB35 RID: 117557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CB35")]
		[Address(RVA = "0x1629250", Offset = "0x1627E50", VA = "0x181629250")]
		private void _UpdateView()
		{
		}

		// Token: 0x0601CB36 RID: 117558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CB36")]
		[Address(RVA = "0x1628BC0", Offset = "0x16277C0", VA = "0x181628BC0")]
		public void EventOnConfirmClicked()
		{
		}

		// Token: 0x0601CB37 RID: 117559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CB37")]
		[Address(RVA = "0x1628F80", Offset = "0x1627B80", VA = "0x181628F80")]
		private void _OnVoiceItemClicked(VoiceLangManager.HotUpdatePref pref)
		{
		}

		// Token: 0x0601CB38 RID: 117560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601CB38")]
		[Address(RVA = "0x1629360", Offset = "0x1627F60", VA = "0x181629360")]
		public HotUpdateVoicePrefView()
		{
		}

		// Token: 0x04025AE8 RID: 154344
		[Token(Token = "0x4025AE8")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SimpleLayoutContent _selectionLayout;

		// Token: 0x04025AE9 RID: 154345
		[Token(Token = "0x4025AE9")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CanvasGroup _alphaHandler;

		// Token: 0x04025AEA RID: 154346
		[Token(Token = "0x4025AEA")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TwoStateToggle _btnToggle;

		// Token: 0x04025AEB RID: 154347
		[Token(Token = "0x4025AEB")]
		[FieldOffset(Offset = "0x30")]
		private HotUpdateVoicePrefView.ViewModel m_viewModel;

		// Token: 0x04025AEC RID: 154348
		[Token(Token = "0x4025AEC")]
		[FieldOffset(Offset = "0x38")]
		private HotUpdateVoicePrefView.Adapter m_adapter;

		// Token: 0x04025AED RID: 154349
		[Token(Token = "0x4025AED")]
		[FieldOffset(Offset = "0x40")]
		private FadeSwitchTween m_displayTween;

		// Token: 0x04025AEE RID: 154350
		[Token(Token = "0x4025AEE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04025AEF RID: 154351
		[Token(Token = "0x4025AEF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__Show;

		// Token: 0x04025AF0 RID: 154352
		[Token(Token = "0x4025AF0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__Hide;

		// Token: 0x04025AF1 RID: 154353
		[Token(Token = "0x4025AF1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__UpdateView;

		// Token: 0x04025AF2 RID: 154354
		[Token(Token = "0x4025AF2")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnConfirmClicked;

		// Token: 0x04025AF3 RID: 154355
		[Token(Token = "0x4025AF3")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnVoiceItemClicked;

		// Token: 0x04025AF4 RID: 154356
		[Token(Token = "0x4025AF4")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004AA1 RID: 19105
		[Token(Token = "0x2004AA1")]
		public struct ControllerOptions
		{
			// Token: 0x04025AF5 RID: 154357
			[Token(Token = "0x4025AF5")]
			[FieldOffset(Offset = "0x0")]
			public RectTransform container;

			// Token: 0x04025AF6 RID: 154358
			[Token(Token = "0x4025AF6")]
			[FieldOffset(Offset = "0x8")]
			public HotUpdateVoicePrefView prefab;
		}

		// Token: 0x02004AA2 RID: 19106
		[Token(Token = "0x2004AA2")]
		public class Controller : IHotfixable
		{
			// Token: 0x0601CB39 RID: 117561 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601CB39")]
			[Address(RVA = "0x16214B0", Offset = "0x16200B0", VA = "0x1816214B0")]
			public Controller(HotUpdateVoicePrefView.ControllerOptions options)
			{
			}

			// Token: 0x0601CB3A RID: 117562 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601CB3A")]
			[Address(RVA = "0x16213B0", Offset = "0x161FFB0", VA = "0x1816213B0")]
			public void Show()
			{
			}

			// Token: 0x04025AF7 RID: 154359
			[Token(Token = "0x4025AF7")]
			[FieldOffset(Offset = "0x10")]
			private HotUpdateVoicePrefView.ControllerOptions m_options;

			// Token: 0x04025AF8 RID: 154360
			[Token(Token = "0x4025AF8")]
			[FieldOffset(Offset = "0x20")]
			private HotUpdateVoicePrefView m_inst;

			// Token: 0x04025AF9 RID: 154361
			[Token(Token = "0x4025AF9")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04025AFA RID: 154362
			[Token(Token = "0x4025AFA")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_Show;
		}

		// Token: 0x02004AA3 RID: 19107
		[Token(Token = "0x2004AA3")]
		private class ViewModel : IHotfixable
		{
			// Token: 0x0601CB3B RID: 117563 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601CB3B")]
			[Address(RVA = "0x1635C60", Offset = "0x1634860", VA = "0x181635C60")]
			public static HotUpdateVoicePrefView.ViewModel Create()
			{
				return null;
			}

			// Token: 0x0601CB3C RID: 117564 RVA: 0x000A9218 File Offset: 0x000A7418
			[Token(Token = "0x601CB3C")]
			[Address(RVA = "0x1635FA0", Offset = "0x1634BA0", VA = "0x181635FA0")]
			public bool IsConfirmable()
			{
				return default(bool);
			}

			// Token: 0x0601CB3D RID: 117565 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601CB3D")]
			[Address(RVA = "0x1636000", Offset = "0x1634C00", VA = "0x181636000")]
			private static List<VoiceLangManager.HotUpdatePref> _BuildSelectableList()
			{
				return null;
			}

			// Token: 0x0601CB3E RID: 117566 RVA: 0x000A9230 File Offset: 0x000A7430
			[Token(Token = "0x601CB3E")]
			[Address(RVA = "0x16362C0", Offset = "0x1634EC0", VA = "0x1816362C0")]
			private static VoiceLangManager.HotUpdatePref _ConvertSelectableType(VoiceLangType voiceLang)
			{
				return VoiceLangManager.HotUpdatePref.NONE;
			}

			// Token: 0x0601CB3F RID: 117567 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601CB3F")]
			[Address(RVA = "0x1636360", Offset = "0x1634F60", VA = "0x181636360")]
			public ViewModel()
			{
			}

			// Token: 0x04025AFB RID: 154363
			[Token(Token = "0x4025AFB")]
			[FieldOffset(Offset = "0x10")]
			public List<VoiceLangManager.HotUpdatePref> selectablePrefs;

			// Token: 0x04025AFC RID: 154364
			[Token(Token = "0x4025AFC")]
			[FieldOffset(Offset = "0x18")]
			public VoiceLangManager.HotUpdatePref selected;

			// Token: 0x04025AFD RID: 154365
			[Token(Token = "0x4025AFD")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Create;

			// Token: 0x04025AFE RID: 154366
			[Token(Token = "0x4025AFE")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_IsConfirmable;

			// Token: 0x04025AFF RID: 154367
			[Token(Token = "0x4025AFF")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0__BuildSelectableList;

			// Token: 0x04025B00 RID: 154368
			[Token(Token = "0x4025B00")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0__ConvertSelectableType;

			// Token: 0x04025B01 RID: 154369
			[Token(Token = "0x4025B01")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02004AA4 RID: 19108
		[Token(Token = "0x2004AA4")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x0601CB40 RID: 117568 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601CB40")]
			[Address(RVA = "0x16204E0", Offset = "0x161F0E0", VA = "0x1816204E0")]
			public Adapter(HotUpdateVoicePrefView closure)
			{
			}

			// Token: 0x170043B1 RID: 17329
			// (get) Token: 0x0601CB41 RID: 117569 RVA: 0x000A9248 File Offset: 0x000A7448
			[Token(Token = "0x170043B1")]
			public override int count
			{
				[Token(Token = "0x601CB41")]
				[Address(RVA = "0x1620560", Offset = "0x161F160", VA = "0x181620560", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601CB42 RID: 117570 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601CB42")]
			[Address(RVA = "0x1620000", Offset = "0x161EC00", VA = "0x181620000", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04025B02 RID: 154370
			[Token(Token = "0x4025B02")]
			[FieldOffset(Offset = "0x20")]
			private HotUpdateVoicePrefView m_closure;

			// Token: 0x04025B03 RID: 154371
			[Token(Token = "0x4025B03")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04025B04 RID: 154372
			[Token(Token = "0x4025B04")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04025B05 RID: 154373
			[Token(Token = "0x4025B05")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
