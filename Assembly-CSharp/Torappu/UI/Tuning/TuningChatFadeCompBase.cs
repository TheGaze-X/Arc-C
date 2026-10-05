using System;
using System.Collections;
using Il2CppDummyDll;
using Torappu.AVG;
using UnityEngine;
using XLua;

namespace Torappu.UI.Tuning
{
	// Token: 0x02003C5D RID: 15453
	[Token(Token = "0x2003C5D")]
	public abstract class TuningChatFadeCompBase : MonoBehaviour, IHotfixable
	{
		// Token: 0x06018259 RID: 98905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018259")]
		[Address(RVA = "0x10903E0", Offset = "0x108EFE0", VA = "0x1810903E0")]
		private void _SetDisplay(bool isShow, bool useFastMode)
		{
		}

		// Token: 0x0601825A RID: 98906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601825A")]
		[Address(RVA = "0x1090510", Offset = "0x108F110", VA = "0x181090510")]
		protected TuningChatFadeCompBase()
		{
		}

		// Token: 0x0401D5C1 RID: 120257
		[Token(Token = "0x401D5C1")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x0401D5C2 RID: 120258
		[Token(Token = "0x401D5C2")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _fadeDuration;

		// Token: 0x0401D5C3 RID: 120259
		[Token(Token = "0x401D5C3")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float _postDelay;

		// Token: 0x0401D5C4 RID: 120260
		[Token(Token = "0x401D5C4")]
		[FieldOffset(Offset = "0x28")]
		private FadeSwitchTween m_switchTween;

		// Token: 0x0401D5C5 RID: 120261
		[Token(Token = "0x401D5C5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__SetDisplay;

		// Token: 0x0401D5C6 RID: 120262
		[Token(Token = "0x401D5C6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003C5E RID: 15454
		[Token(Token = "0x2003C5E")]
		public abstract class VirtualViewBase<T> : AVGChatVirtualView<T> where T : TuningChatFadeCompBase
		{
			// Token: 0x0601825B RID: 98907
			[Token(Token = "0x601825B")]
			protected abstract T FadePrefab();

			// Token: 0x0601825C RID: 98908
			[Token(Token = "0x601825C")]
			protected abstract float GetPreferedHeight();

			// Token: 0x0601825D RID: 98909 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601825D")]
			protected virtual void BeforePlayFade(T view)
			{
			}

			// Token: 0x0601825E RID: 98910 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601825E")]
			protected virtual IEnumerator PlayView(T view)
			{
				return null;
			}

			// Token: 0x0601825F RID: 98911 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601825F")]
			public override GameObject GetPrefab()
			{
				return null;
			}

			// Token: 0x06018260 RID: 98912 RVA: 0x000998D0 File Offset: 0x00097AD0
			[Token(Token = "0x6018260")]
			public override float GetPreferSize()
			{
				return 0f;
			}

			// Token: 0x06018261 RID: 98913 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018261")]
			protected override void HideViewContent(T view)
			{
			}

			// Token: 0x06018262 RID: 98914 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6018262")]
			protected override IEnumerator PlayViewContent(T view)
			{
				return null;
			}

			// Token: 0x06018263 RID: 98915 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018263")]
			protected override void ShowAsLog(T view)
			{
			}

			// Token: 0x06018264 RID: 98916 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018264")]
			protected override void ShowAsRecord(T view)
			{
			}

			// Token: 0x06018265 RID: 98917 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018265")]
			protected VirtualViewBase()
			{
			}

			// Token: 0x0401D5C7 RID: 120263
			[Token(Token = "0x401D5C7")]
			[FieldOffset(Offset = "0x0")]
			private float m_cachedSize;

			// Token: 0x0401D5C8 RID: 120264
			[Token(Token = "0x401D5C8")]
			[FieldOffset(Offset = "0x0")]
			private string m_dialogContent;

			// Token: 0x0401D5C9 RID: 120265
			[Token(Token = "0x401D5C9")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_BeforePlayFade;

			// Token: 0x0401D5CA RID: 120266
			[Token(Token = "0x401D5CA")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_PlayView;

			// Token: 0x0401D5CB RID: 120267
			[Token(Token = "0x401D5CB")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_GetPrefab;

			// Token: 0x0401D5CC RID: 120268
			[Token(Token = "0x401D5CC")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_GetPreferSize;

			// Token: 0x0401D5CD RID: 120269
			[Token(Token = "0x401D5CD")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_HideViewContent;

			// Token: 0x0401D5CE RID: 120270
			[Token(Token = "0x401D5CE")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_PlayViewContent;

			// Token: 0x0401D5CF RID: 120271
			[Token(Token = "0x401D5CF")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_ShowAsLog;

			// Token: 0x0401D5D0 RID: 120272
			[Token(Token = "0x401D5D0")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_ShowAsRecord;

			// Token: 0x0401D5D1 RID: 120273
			[Token(Token = "0x401D5D1")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
