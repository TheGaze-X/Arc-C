using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.Setting;
using Torappu.Video;
using UnityEngine;
using XLua;

namespace Torappu.AVG
{
	// Token: 0x02001EBD RID: 7869
	[Token(Token = "0x2001EBD")]
	[RequireComponent(typeof(CanvasGroup))]
	public class AVGVideoPanel : ExecutorComponent
	{
		// Token: 0x0600C2F9 RID: 49913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C2F9")]
		[Address(RVA = "0x3405680", Offset = "0x3404280", VA = "0x183405680")]
		private void Awake()
		{
		}

		// Token: 0x0600C2FA RID: 49914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C2FA")]
		[Address(RVA = "0x3406440", Offset = "0x3405040", VA = "0x183406440")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0600C2FB RID: 49915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C2FB")]
		[Address(RVA = "0x3405A30", Offset = "0x3404630", VA = "0x183405A30", Slot = "7")]
		public override void OnReset()
		{
		}

		// Token: 0x0600C2FC RID: 49916 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C2FC")]
		[Address(RVA = "0x3405890", Offset = "0x3404490", VA = "0x183405890", Slot = "8")]
		public override Dictionary<string, ExecutorComponent.Executor> GetExecutors()
		{
			return null;
		}

		// Token: 0x0600C2FD RID: 49917 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C2FD")]
		[Address(RVA = "0x3405780", Offset = "0x3404380", VA = "0x183405780")]
		public AbstractResRefCollecter DontInvoke_PlzImplInternalResRefCollector()
		{
			return null;
		}

		// Token: 0x0600C2FE RID: 49918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C2FE")]
		[Address(RVA = "0x3405810", Offset = "0x3404410", VA = "0x183405810", Slot = "12")]
		protected override void ForceCommandEnd()
		{
		}

		// Token: 0x0600C2FF RID: 49919 RVA: 0x00047988 File Offset: 0x00045B88
		[Token(Token = "0x600C2FF")]
		[Address(RVA = "0x34067B0", Offset = "0x34053B0", VA = "0x1834067B0")]
		private bool _PlayVideo(Command command, out string url)
		{
			return default(bool);
		}

		// Token: 0x0600C300 RID: 49920 RVA: 0x000479A0 File Offset: 0x00045BA0
		[Token(Token = "0x600C300")]
		[Address(RVA = "0x3406060", Offset = "0x3404C60", VA = "0x183406060")]
		private bool _ExecuteVideo(Command command)
		{
			return default(bool);
		}

		// Token: 0x0600C301 RID: 49921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C301")]
		[Address(RVA = "0x34062F0", Offset = "0x3404EF0", VA = "0x1834062F0")]
		private void _HandlePlayEvent(AbstractMediaPlayerHolder.Status status)
		{
		}

		// Token: 0x0600C302 RID: 49922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C302")]
		[Address(RVA = "0x34059B0", Offset = "0x34045B0", VA = "0x1834059B0", Slot = "11")]
		protected override void OnFinish()
		{
		}

		// Token: 0x0600C303 RID: 49923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C303")]
		[Address(RVA = "0x34069C0", Offset = "0x34055C0", VA = "0x1834069C0")]
		private void _SetHiddenInternal(bool value, bool force)
		{
		}

		// Token: 0x0600C304 RID: 49924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C304")]
		[Address(RVA = "0x3405D10", Offset = "0x3404910", VA = "0x183405D10")]
		private void _DisposeVideo(float closeDelay = 0f, [Optional] Action callback)
		{
		}

		// Token: 0x0600C305 RID: 49925 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C305")]
		[Address(RVA = "0x3406C10", Offset = "0x3405810", VA = "0x183406C10")]
		private IEnumerator _StopCoro([Optional] Action callback)
		{
			return null;
		}

		// Token: 0x0600C306 RID: 49926 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C306")]
		[Address(RVA = "0x3406B60", Offset = "0x3405760", VA = "0x183406B60")]
		private IEnumerator _StartPlayCoroutine()
		{
			return null;
		}

		// Token: 0x0600C307 RID: 49927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C307")]
		[Address(RVA = "0x3406500", Offset = "0x3405100", VA = "0x183406500")]
		private void _InitSettingsIfNot()
		{
		}

		// Token: 0x0600C308 RID: 49928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C308")]
		[Address(RVA = "0x3406730", Offset = "0x3405330", VA = "0x183406730")]
		private void _OnSettingChange(SettingConstVars.SettingType type)
		{
		}

		// Token: 0x0600C309 RID: 49929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C309")]
		[Address(RVA = "0x3405C40", Offset = "0x3404840", VA = "0x183405C40")]
		private void _ApplyMusicSettings()
		{
		}

		// Token: 0x0600C30A RID: 49930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C30A")]
		[Address(RVA = "0x3406CE0", Offset = "0x34058E0", VA = "0x183406CE0")]
		public AVGVideoPanel()
		{
		}

		// Token: 0x0600C30C RID: 49932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C30C")]
		[Address(RVA = "0x1C5FCF0", Offset = "0x1C5E8F0", VA = "0x181C5FCF0")]
		private void <>xLuaBaseProxy_OnReset()
		{
		}

		// Token: 0x0600C30D RID: 49933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C30D")]
		[Address(RVA = "0x33F4E00", Offset = "0x33F3A00", VA = "0x1833F4E00")]
		private void <>xLuaBaseProxy_OnFinish()
		{
		}

		// Token: 0x0400C50F RID: 50447
		[Token(Token = "0x400C50F")]
		private const float FADE_DURATION = 0.23f;

		// Token: 0x0400C510 RID: 50448
		[Token(Token = "0x400C510")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Transform _mediaPlayerContainer;

		// Token: 0x0400C511 RID: 50449
		[Token(Token = "0x400C511")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Ease _hideEase;

		// Token: 0x0400C512 RID: 50450
		[Token(Token = "0x400C512")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Coroutine m_startPlayCoroutine;

		// Token: 0x0400C513 RID: 50451
		[Token(Token = "0x400C513")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private Coroutine m_stopPlayCoroutine;

		// Token: 0x0400C514 RID: 50452
		[Token(Token = "0x400C514")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Tween m_disposeVideoTween;

		// Token: 0x0400C515 RID: 50453
		[Token(Token = "0x400C515")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private CanvasGroup m_canvasGroup;

		// Token: 0x0400C516 RID: 50454
		[Token(Token = "0x400C516")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private bool m_hidden;

		// Token: 0x0400C517 RID: 50455
		[Token(Token = "0x400C517")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private AbstractMediaPlayerHolder m_mediaPlayer;

		// Token: 0x0400C518 RID: 50456
		[Token(Token = "0x400C518")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private bool m_isInited;

		// Token: 0x0400C519 RID: 50457
		[Token(Token = "0x400C519")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x91")]
		private bool m_isSettingInited;

		// Token: 0x0400C51A RID: 50458
		[Token(Token = "0x400C51A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x0400C51B RID: 50459
		[Token(Token = "0x400C51B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0400C51C RID: 50460
		[Token(Token = "0x400C51C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnReset;

		// Token: 0x0400C51D RID: 50461
		[Token(Token = "0x400C51D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetExecutors;

		// Token: 0x0400C51E RID: 50462
		[Token(Token = "0x400C51E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_DontInvoke_PlzImplInternalResRefCollector;

		// Token: 0x0400C51F RID: 50463
		[Token(Token = "0x400C51F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_ForceCommandEnd;

		// Token: 0x0400C520 RID: 50464
		[Token(Token = "0x400C520")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__PlayVideo;

		// Token: 0x0400C521 RID: 50465
		[Token(Token = "0x400C521")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__ExecuteVideo;

		// Token: 0x0400C522 RID: 50466
		[Token(Token = "0x400C522")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__HandlePlayEvent;

		// Token: 0x0400C523 RID: 50467
		[Token(Token = "0x400C523")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnFinish;

		// Token: 0x0400C524 RID: 50468
		[Token(Token = "0x400C524")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__SetHiddenInternal;

		// Token: 0x0400C525 RID: 50469
		[Token(Token = "0x400C525")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__DisposeVideo;

		// Token: 0x0400C526 RID: 50470
		[Token(Token = "0x400C526")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__StopCoro;

		// Token: 0x0400C527 RID: 50471
		[Token(Token = "0x400C527")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__StartPlayCoroutine;

		// Token: 0x0400C528 RID: 50472
		[Token(Token = "0x400C528")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__InitSettingsIfNot;

		// Token: 0x0400C529 RID: 50473
		[Token(Token = "0x400C529")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__OnSettingChange;

		// Token: 0x0400C52A RID: 50474
		[Token(Token = "0x400C52A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__ApplyMusicSettings;

		// Token: 0x0400C52B RID: 50475
		[Token(Token = "0x400C52B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001EBE RID: 7870
		[Token(Token = "0x2001EBE")]
		private class InternalResRefCollector : AbstractResRefCollecter
		{
			// Token: 0x0600C30E RID: 49934 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C30E")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "4")]
			public override void GatherResRefs(Command command, HashSet<string> references)
			{
			}

			// Token: 0x0600C30F RID: 49935 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C30F")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			public InternalResRefCollector()
			{
			}
		}
	}
}
