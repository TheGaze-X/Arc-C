using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.CGGallery
{
	// Token: 0x02005FD8 RID: 24536
	[Token(Token = "0x2005FD8")]
	public class CGGalleryPage : StateEnginePage
	{
		// Token: 0x170053B0 RID: 21424
		// (get) Token: 0x0602377B RID: 145275 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170053B0")]
		public CGGalleryProperty property
		{
			[Token(Token = "0x602377B")]
			[Address(RVA = "0x1E19E60", Offset = "0x1E18A60", VA = "0x181E19E60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x0602377C RID: 145276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602377C")]
		[Address(RVA = "0x1E18A10", Offset = "0x1E17610", VA = "0x181E18A10", Slot = "8")]
		protected override void OnCreate(DataBundle savedInst)
		{
		}

		// Token: 0x0602377D RID: 145277 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602377D")]
		[Address(RVA = "0x1E18720", Offset = "0x1E17320", VA = "0x181E18720", Slot = "27")]
		protected override IEnumerator InitStateEngine()
		{
			return null;
		}

		// Token: 0x0602377E RID: 145278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602377E")]
		[Address(RVA = "0x1E18CE0", Offset = "0x1E178E0", VA = "0x181E18CE0", Slot = "10")]
		protected override void OnStart()
		{
		}

		// Token: 0x0602377F RID: 145279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602377F")]
		[Address(RVA = "0x1E187D0", Offset = "0x1E173D0", VA = "0x181E187D0")]
		public void OnBackPressed()
		{
		}

		// Token: 0x06023780 RID: 145280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023780")]
		[Address(RVA = "0x1E19300", Offset = "0x1E17F00", VA = "0x181E19300")]
		public void PlayStory(StoryData targetStory)
		{
		}

		// Token: 0x06023781 RID: 145281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023781")]
		[Address(RVA = "0x1E19710", Offset = "0x1E18310", VA = "0x181E19710")]
		private void _OnGetFavouriteProceed(CGGalleryGetFavouriteResponse response)
		{
		}

		// Token: 0x06023782 RID: 145282 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023782")]
		[Address(RVA = "0x1E198D0", Offset = "0x1E184D0", VA = "0x181E198D0")]
		private IEnumerator _RouteToProperState()
		{
			return null;
		}

		// Token: 0x06023783 RID: 145283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023783")]
		[Address(RVA = "0x1E19680", Offset = "0x1E18280", VA = "0x181E19680")]
		private void _OnBackHideChanged(bool hide)
		{
		}

		// Token: 0x06023784 RID: 145284 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023784")]
		[Address(RVA = "0x1E19980", Offset = "0x1E18580", VA = "0x181E19980")]
		private static UIPageControllerParam _SceneParamToState(string storylineId, string storySetId, string displayId, CGGalleryFilterMode filterMode)
		{
			return null;
		}

		// Token: 0x06023785 RID: 145285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023785")]
		[Address(RVA = "0x1E19D70", Offset = "0x1E18970", VA = "0x181E19D70")]
		public CGGalleryPage()
		{
		}

		// Token: 0x06023786 RID: 145286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023786")]
		[Address(RVA = "0xE66190", Offset = "0xE64D90", VA = "0x180E66190")]
		private void <>xLuaBaseProxy_OnCreate(DataBundle P0)
		{
		}

		// Token: 0x06023787 RID: 145287 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023787")]
		[Address(RVA = "0xE66180", Offset = "0xE64D80", VA = "0x180E66180")]
		private IEnumerator <>xLuaBaseProxy_InitStateEngine()
		{
			return null;
		}

		// Token: 0x06023788 RID: 145288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023788")]
		[Address(RVA = "0x1071290", Offset = "0x106FE90", VA = "0x181071290")]
		private void <>xLuaBaseProxy_OnStart()
		{
		}

		// Token: 0x04031119 RID: 200985
		[Token(Token = "0x4031119")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private RectTransform _backButtonRect;

		// Token: 0x0403111A RID: 200986
		[Token(Token = "0x403111A")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private CanvasGroup _backButtonGroup;

		// Token: 0x0403111B RID: 200987
		[Token(Token = "0x403111B")]
		[FieldOffset(Offset = "0x100")]
		private List<string> m_favouriteCgList;

		// Token: 0x0403111C RID: 200988
		[Token(Token = "0x403111C")]
		[FieldOffset(Offset = "0x108")]
		private FadeSwitchTween m_backSwitchTween;

		// Token: 0x0403111D RID: 200989
		[Token(Token = "0x403111D")]
		[FieldOffset(Offset = "0x110")]
		private CGGalleryPage.StateChangeListener m_stateChangeListener;

		// Token: 0x0403111F RID: 200991
		[Token(Token = "0x403111F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_property;

		// Token: 0x04031120 RID: 200992
		[Token(Token = "0x4031120")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x04031121 RID: 200993
		[Token(Token = "0x4031121")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_InitStateEngine;

		// Token: 0x04031122 RID: 200994
		[Token(Token = "0x4031122")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnStart;

		// Token: 0x04031123 RID: 200995
		[Token(Token = "0x4031123")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnBackPressed;

		// Token: 0x04031124 RID: 200996
		[Token(Token = "0x4031124")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_PlayStory;

		// Token: 0x04031125 RID: 200997
		[Token(Token = "0x4031125")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnGetFavouriteProceed;

		// Token: 0x04031126 RID: 200998
		[Token(Token = "0x4031126")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__RouteToProperState;

		// Token: 0x04031127 RID: 200999
		[Token(Token = "0x4031127")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnBackHideChanged;

		// Token: 0x04031128 RID: 201000
		[Token(Token = "0x4031128")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__SceneParamToState;

		// Token: 0x04031129 RID: 201001
		[Token(Token = "0x4031129")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005FD9 RID: 24537
		[Token(Token = "0x2005FD9")]
		public class Arguments
		{
			// Token: 0x06023789 RID: 145289 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6023789")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Arguments()
			{
			}

			// Token: 0x0403112A RID: 201002
			[Token(Token = "0x403112A")]
			[FieldOffset(Offset = "0x10")]
			public string storylineId;

			// Token: 0x0403112B RID: 201003
			[Token(Token = "0x403112B")]
			[FieldOffset(Offset = "0x18")]
			public string storySetId;

			// Token: 0x0403112C RID: 201004
			[Token(Token = "0x403112C")]
			[FieldOffset(Offset = "0x20")]
			public string displayId;

			// Token: 0x0403112D RID: 201005
			[Token(Token = "0x403112D")]
			[FieldOffset(Offset = "0x28")]
			public CGGalleryFilterMode filterMode;
		}

		// Token: 0x02005FDA RID: 24538
		[Token(Token = "0x2005FDA")]
		public interface IBackControl
		{
			// Token: 0x1400008A RID: 138
			// (add) Token: 0x0602378A RID: 145290
			// (remove) Token: 0x0602378B RID: 145291
			[Token(Token = "0x1400008A")]
			event Action<bool> onBackHideChanged;

			// Token: 0x170053B1 RID: 21425
			// (get) Token: 0x0602378C RID: 145292
			[Token(Token = "0x170053B1")]
			Func<bool> backAction { [Token(Token = "0x602378C")] get; }
		}

		// Token: 0x02005FDB RID: 24539
		[Token(Token = "0x2005FDB")]
		private class StateChangeListener : StateEngine.OnStateChangeListener
		{
			// Token: 0x170053B2 RID: 21426
			// (get) Token: 0x0602378D RID: 145293 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170053B2")]
			public Func<bool> backAction
			{
				[Token(Token = "0x602378D")]
				[Address(RVA = "0x1E26EF0", Offset = "0x1E25AF0", VA = "0x181E26EF0")]
				get
				{
					return null;
				}
			}

			// Token: 0x0602378E RID: 145294 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602378E")]
			[Address(RVA = "0x1E26E00", Offset = "0x1E25A00", VA = "0x181E26E00")]
			public StateChangeListener(CGGalleryPage closure)
			{
			}

			// Token: 0x0602378F RID: 145295 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602378F")]
			[Address(RVA = "0x1E26D00", Offset = "0x1E25900", VA = "0x181E26D00")]
			private void _OnStateResume(Type state, bool backFromStack, StateEngine.OnStateChangeListener.Additions additions)
			{
			}

			// Token: 0x06023790 RID: 145296 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6023790")]
			[Address(RVA = "0x1E26BC0", Offset = "0x1E257C0", VA = "0x181E26BC0")]
			private void _OnStatePause(Type state, StateEngine.OnStateChangeListener.Additions additions)
			{
			}

			// Token: 0x0403112E RID: 201006
			[Token(Token = "0x403112E")]
			[FieldOffset(Offset = "0x40")]
			private readonly CGGalleryPage m_closure;

			// Token: 0x0403112F RID: 201007
			[Token(Token = "0x403112F")]
			[FieldOffset(Offset = "0x48")]
			private CGGalleryPage.IBackControl m_currentControl;
		}
	}
}
