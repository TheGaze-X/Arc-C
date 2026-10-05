using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004037 RID: 16439
	[Token(Token = "0x2004037")]
	public class SandboxV2ExpeditionEnsureView : SandboxV2AdminCharAbstractEnsureView
	{
		// Token: 0x06019702 RID: 104194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019702")]
		[Address(RVA = "0x1220D10", Offset = "0x121F910", VA = "0x181220D10")]
		public void OnClick()
		{
		}

		// Token: 0x06019703 RID: 104195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019703")]
		[Address(RVA = "0x1220C70", Offset = "0x121F870", VA = "0x181220C70")]
		public void OnClear()
		{
		}

		// Token: 0x06019704 RID: 104196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019704")]
		[Address(RVA = "0x1220F30", Offset = "0x121FB30", VA = "0x181220F30")]
		public void OnProduceDrink()
		{
		}

		// Token: 0x06019705 RID: 104197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019705")]
		[Address(RVA = "0x1220FD0", Offset = "0x121FBD0", VA = "0x181220FD0", Slot = "4")]
		public override void OnUpdateData(SandboxV2CharListViewModel viewModel)
		{
		}

		// Token: 0x06019706 RID: 104198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019706")]
		[Address(RVA = "0x1221510", Offset = "0x1220110", VA = "0x181221510")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06019707 RID: 104199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019707")]
		[Address(RVA = "0x12216C0", Offset = "0x12202C0", VA = "0x1812216C0")]
		private void _LoadIcon(string topicId)
		{
		}

		// Token: 0x06019708 RID: 104200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019708")]
		[Address(RVA = "0x12217D0", Offset = "0x12203D0", VA = "0x1812217D0")]
		public SandboxV2ExpeditionEnsureView()
		{
		}

		// Token: 0x0401FAF5 RID: 129781
		[Token(Token = "0x401FAF5")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _duration;

		// Token: 0x0401FAF6 RID: 129782
		[Token(Token = "0x401FAF6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _drink;

		// Token: 0x0401FAF7 RID: 129783
		[Token(Token = "0x401FAF7")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _drinkObtain;

		// Token: 0x0401FAF8 RID: 129784
		[Token(Token = "0x401FAF8")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _costAction;

		// Token: 0x0401FAF9 RID: 129785
		[Token(Token = "0x401FAF9")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private CanvasGroup _noDrink;

		// Token: 0x0401FAFA RID: 129786
		[Token(Token = "0x401FAFA")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _panelCostAction;

		// Token: 0x0401FAFB RID: 129787
		[Token(Token = "0x401FAFB")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIAtlasImage _startBtnBkg;

		// Token: 0x0401FAFC RID: 129788
		[Token(Token = "0x401FAFC")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Color _colorDisable;

		// Token: 0x0401FAFD RID: 129789
		[Token(Token = "0x401FAFD")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Color _colorEnable;

		// Token: 0x0401FAFE RID: 129790
		[Token(Token = "0x401FAFE")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private SimpleLayoutContent _content;

		// Token: 0x0401FAFF RID: 129791
		[Token(Token = "0x401FAFF")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Image _drinkIcon;

		// Token: 0x0401FB00 RID: 129792
		[Token(Token = "0x401FB00")]
		[FieldOffset(Offset = "0x80")]
		private bool m_isInited;

		// Token: 0x0401FB01 RID: 129793
		[Token(Token = "0x401FB01")]
		[FieldOffset(Offset = "0x88")]
		private SandboxV2ExpeditionEnsureView.Adapter m_adapter;

		// Token: 0x0401FB02 RID: 129794
		[Token(Token = "0x401FB02")]
		[FieldOffset(Offset = "0x90")]
		private FadeSwitchTween m_noDrinkSwitchTween;

		// Token: 0x0401FB03 RID: 129795
		[Token(Token = "0x401FB03")]
		[FieldOffset(Offset = "0x98")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0401FB04 RID: 129796
		[Token(Token = "0x401FB04")]
		[FieldOffset(Offset = "0xA8")]
		private SandboxV2CharListViewModel m_cachedViewModel;

		// Token: 0x0401FB05 RID: 129797
		[Token(Token = "0x401FB05")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0401FB06 RID: 129798
		[Token(Token = "0x401FB06")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnClear;

		// Token: 0x0401FB07 RID: 129799
		[Token(Token = "0x401FB07")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnProduceDrink;

		// Token: 0x0401FB08 RID: 129800
		[Token(Token = "0x401FB08")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnUpdateData;

		// Token: 0x0401FB09 RID: 129801
		[Token(Token = "0x401FB09")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401FB0A RID: 129802
		[Token(Token = "0x401FB0A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__LoadIcon;

		// Token: 0x0401FB0B RID: 129803
		[Token(Token = "0x401FB0B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004038 RID: 16440
		[Token(Token = "0x2004038")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x06019709 RID: 104201 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6019709")]
			[Address(RVA = "0x1212BE0", Offset = "0x12117E0", VA = "0x181212BE0")]
			public Adapter(SandboxV2ExpeditionEnsureView closure)
			{
			}

			// Token: 0x17003C96 RID: 15510
			// (get) Token: 0x0601970A RID: 104202 RVA: 0x0009E058 File Offset: 0x0009C258
			[Token(Token = "0x17003C96")]
			public override int count
			{
				[Token(Token = "0x601970A")]
				[Address(RVA = "0x1212CD0", Offset = "0x12118D0", VA = "0x181212CD0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601970B RID: 104203 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601970B")]
			[Address(RVA = "0x12127E0", Offset = "0x12113E0", VA = "0x1812127E0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0401FB0C RID: 129804
			[Token(Token = "0x401FB0C")]
			[FieldOffset(Offset = "0x20")]
			private SandboxV2ExpeditionEnsureView m_closure;

			// Token: 0x0401FB0D RID: 129805
			[Token(Token = "0x401FB0D")]
			[FieldOffset(Offset = "0x28")]
			private int _count;

			// Token: 0x0401FB0E RID: 129806
			[Token(Token = "0x401FB0E")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401FB0F RID: 129807
			[Token(Token = "0x401FB0F")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0401FB10 RID: 129808
			[Token(Token = "0x401FB10")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
