using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.Audio;
using Torappu.AVG;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.Chat
{
	// Token: 0x020058AB RID: 22699
	[Token(Token = "0x20058AB")]
	public class RoguelikeChatSimpleComp : MonoBehaviour, IHotfixable
	{
		// Token: 0x06021237 RID: 135735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021237")]
		[Address(RVA = "0x1B7C850", Offset = "0x1B7B450", VA = "0x181B7C850")]
		private void _HideContent()
		{
		}

		// Token: 0x06021238 RID: 135736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021238")]
		[Address(RVA = "0x1B7CC20", Offset = "0x1B7B820", VA = "0x181B7CC20")]
		private void _ShowContentImmediately()
		{
		}

		// Token: 0x06021239 RID: 135737 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021239")]
		[Address(RVA = "0x1B7CE00", Offset = "0x1B7BA00", VA = "0x181B7CE00")]
		private IEnumerator _ShowCoroutine()
		{
			return null;
		}

		// Token: 0x0602123A RID: 135738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602123A")]
		[Address(RVA = "0x1B7CA60", Offset = "0x1B7B660", VA = "0x181B7CA60")]
		private void _SetDisplayStatus(RoguelikeChatSimpleComp.DisplayControl config)
		{
		}

		// Token: 0x0602123B RID: 135739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602123B")]
		[Address(RVA = "0x1B7C680", Offset = "0x1B7B280", VA = "0x181B7C680")]
		private void _ClearPlayingItems()
		{
		}

		// Token: 0x0602123C RID: 135740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602123C")]
		[Address(RVA = "0x1B7C610", Offset = "0x1B7B210", VA = "0x181B7C610")]
		public void EventOnViewClicked()
		{
		}

		// Token: 0x0602123D RID: 135741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602123D")]
		[Address(RVA = "0x1B7CEB0", Offset = "0x1B7BAB0", VA = "0x181B7CEB0")]
		public RoguelikeChatSimpleComp()
		{
		}

		// Token: 0x0402D207 RID: 184839
		[Token(Token = "0x402D207")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RoguelikeChatSimpleComp.TextTypeTween _typeTween;

		// Token: 0x0402D208 RID: 184840
		[Token(Token = "0x402D208")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RoguelikeChatSimpleComp.CanvasGroupFade _fadeIn;

		// Token: 0x0402D209 RID: 184841
		[Token(Token = "0x402D209")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RoguelikeChatSimpleComp.ClickButton _button;

		// Token: 0x0402D20A RID: 184842
		[Token(Token = "0x402D20A")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIAnimationLocation _animShow;

		// Token: 0x0402D20B RID: 184843
		[Token(Token = "0x402D20B")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private RoguelikeChatSimpleComp.UIAudioPlayer _audioSignal;

		// Token: 0x0402D20C RID: 184844
		[Token(Token = "0x402D20C")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _text;

		// Token: 0x0402D20D RID: 184845
		[Token(Token = "0x402D20D")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Image _image;

		// Token: 0x0402D20E RID: 184846
		[Token(Token = "0x402D20E")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _activeObj;

		// Token: 0x0402D20F RID: 184847
		[Token(Token = "0x402D20F")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private float _height;

		// Token: 0x0402D210 RID: 184848
		[Token(Token = "0x402D210")]
		[FieldOffset(Offset = "0x8C")]
		[SerializeField]
		private float _postDelay;

		// Token: 0x0402D211 RID: 184849
		[Token(Token = "0x402D211")]
		[FieldOffset(Offset = "0x90")]
		private List<RoguelikeChatSimpleComp.PlayItem> m_playList;

		// Token: 0x0402D212 RID: 184850
		[Token(Token = "0x402D212")]
		[FieldOffset(Offset = "0x98")]
		private RoguelikeChatSimpleComp.DisplayControl m_displayStatus;

		// Token: 0x0402D213 RID: 184851
		[Token(Token = "0x402D213")]
		[FieldOffset(Offset = "0xB8")]
		private string m_initTypeWirterText;

		// Token: 0x0402D214 RID: 184852
		[Token(Token = "0x402D214")]
		[FieldOffset(Offset = "0xC0")]
		private Action m_onClicked;

		// Token: 0x0402D215 RID: 184853
		[Token(Token = "0x402D215")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__HideContent;

		// Token: 0x0402D216 RID: 184854
		[Token(Token = "0x402D216")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__ShowContentImmediately;

		// Token: 0x0402D217 RID: 184855
		[Token(Token = "0x402D217")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__ShowCoroutine;

		// Token: 0x0402D218 RID: 184856
		[Token(Token = "0x402D218")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__SetDisplayStatus;

		// Token: 0x0402D219 RID: 184857
		[Token(Token = "0x402D219")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__ClearPlayingItems;

		// Token: 0x0402D21A RID: 184858
		[Token(Token = "0x402D21A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_EventOnViewClicked;

		// Token: 0x0402D21B RID: 184859
		[Token(Token = "0x402D21B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020058AC RID: 22700
		[Token(Token = "0x20058AC")]
		public abstract class VirtualView : AVGChatVirtualView<RoguelikeChatSimpleComp>, IChatDelayView, UIRecycleLayoutAdapter.IVirtualView, IHotfixable
		{
			// Token: 0x0602123E RID: 135742
			[Token(Token = "0x602123E")]
			protected abstract RoguelikeChatSimpleComp SimplePrefab();

			// Token: 0x0602123F RID: 135743
			[Token(Token = "0x602123F")]
			protected abstract RoguelikeChatSimpleComp.DisplayControl UpdateContent();

			// Token: 0x06021240 RID: 135744 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021240")]
			[Address(RVA = "0x1B708C0", Offset = "0x1B6F4C0", VA = "0x181B708C0", Slot = "29")]
			protected virtual void OnViewClicked()
			{
			}

			// Token: 0x06021241 RID: 135745 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021241")]
			[Address(RVA = "0x1B87920", Offset = "0x1B86520", VA = "0x181B87920", Slot = "26")]
			public void ResetDelay(float delay)
			{
			}

			// Token: 0x06021242 RID: 135746 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6021242")]
			[Address(RVA = "0x1B86E90", Offset = "0x1B85A90", VA = "0x181B86E90", Slot = "12")]
			public sealed override GameObject GetPrefab()
			{
				return null;
			}

			// Token: 0x06021243 RID: 135747 RVA: 0x000B8B18 File Offset: 0x000B6D18
			[Token(Token = "0x6021243")]
			[Address(RVA = "0x1B86F80", Offset = "0x1B85B80", VA = "0x181B86F80", Slot = "13")]
			public sealed override float GetPreferSize()
			{
				return 0f;
			}

			// Token: 0x06021244 RID: 135748 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021244")]
			[Address(RVA = "0x1B872B0", Offset = "0x1B85EB0", VA = "0x181B872B0", Slot = "20")]
			protected override void HideViewContent(RoguelikeChatSimpleComp view)
			{
			}

			// Token: 0x06021245 RID: 135749 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021245")]
			[Address(RVA = "0x1B87330", Offset = "0x1B85F30", VA = "0x181B87330", Slot = "22")]
			protected override void OnUpdateView(RoguelikeChatSimpleComp view)
			{
			}

			// Token: 0x06021246 RID: 135750 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6021246")]
			[Address(RVA = "0x1B877A0", Offset = "0x1B863A0", VA = "0x181B877A0", Slot = "21")]
			protected override IEnumerator PlayViewContent(RoguelikeChatSimpleComp view)
			{
				return null;
			}

			// Token: 0x06021247 RID: 135751 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021247")]
			[Address(RVA = "0x1B87990", Offset = "0x1B86590", VA = "0x181B87990", Slot = "23")]
			protected override void ShowAsLog(RoguelikeChatSimpleComp view)
			{
			}

			// Token: 0x06021248 RID: 135752 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021248")]
			[Address(RVA = "0x1B87AB0", Offset = "0x1B866B0", VA = "0x181B87AB0")]
			protected VirtualView()
			{
			}

			// Token: 0x0402D21C RID: 184860
			[Token(Token = "0x402D21C")]
			[FieldOffset(Offset = "0x28")]
			private GameObject m_cachedPrefab;

			// Token: 0x0402D21D RID: 184861
			[Token(Token = "0x402D21D")]
			[FieldOffset(Offset = "0x30")]
			private float m_cachedHeight;

			// Token: 0x0402D21E RID: 184862
			[Token(Token = "0x402D21E")]
			[FieldOffset(Offset = "0x34")]
			private float m_delay;

			// Token: 0x0402D21F RID: 184863
			[Token(Token = "0x402D21F")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_OnViewClicked;

			// Token: 0x0402D220 RID: 184864
			[Token(Token = "0x402D220")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_ResetDelay;

			// Token: 0x0402D221 RID: 184865
			[Token(Token = "0x402D221")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GetPrefab;

			// Token: 0x0402D222 RID: 184866
			[Token(Token = "0x402D222")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_GetPreferSize;

			// Token: 0x0402D223 RID: 184867
			[Token(Token = "0x402D223")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_HideViewContent;

			// Token: 0x0402D224 RID: 184868
			[Token(Token = "0x402D224")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_OnUpdateView;

			// Token: 0x0402D225 RID: 184869
			[Token(Token = "0x402D225")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_PlayViewContent;

			// Token: 0x0402D226 RID: 184870
			[Token(Token = "0x402D226")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_ShowAsLog;

			// Token: 0x0402D227 RID: 184871
			[Token(Token = "0x402D227")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x020058AE RID: 22702
		[Token(Token = "0x20058AE")]
		[Serializable]
		private struct TextTypeTween
		{
			// Token: 0x0602124F RID: 135759 RVA: 0x000B8B48 File Offset: 0x000B6D48
			[Token(Token = "0x602124F")]
			[Address(RVA = "0x1B83790", Offset = "0x1B82390", VA = "0x181B83790")]
			public bool IsEmpty()
			{
				return default(bool);
			}

			// Token: 0x0402D22C RID: 184876
			[Token(Token = "0x402D22C")]
			[FieldOffset(Offset = "0x0")]
			public float delay;

			// Token: 0x0402D22D RID: 184877
			[Token(Token = "0x402D22D")]
			[FieldOffset(Offset = "0x4")]
			public float duration;

			// Token: 0x0402D22E RID: 184878
			[Token(Token = "0x402D22E")]
			[FieldOffset(Offset = "0x8")]
			public Text text;
		}

		// Token: 0x020058AF RID: 22703
		[Token(Token = "0x20058AF")]
		[Serializable]
		private struct CanvasGroupFade
		{
			// Token: 0x06021250 RID: 135760 RVA: 0x000B8B60 File Offset: 0x000B6D60
			[Token(Token = "0x6021250")]
			[Address(RVA = "0x1B70700", Offset = "0x1B6F300", VA = "0x181B70700")]
			public bool IsEmpty()
			{
				return default(bool);
			}

			// Token: 0x0402D22F RID: 184879
			[Token(Token = "0x402D22F")]
			[FieldOffset(Offset = "0x0")]
			public float delay;

			// Token: 0x0402D230 RID: 184880
			[Token(Token = "0x402D230")]
			[FieldOffset(Offset = "0x4")]
			public float duration;

			// Token: 0x0402D231 RID: 184881
			[Token(Token = "0x402D231")]
			[FieldOffset(Offset = "0x8")]
			public CanvasGroup canvasGroup;
		}

		// Token: 0x020058B0 RID: 22704
		[Token(Token = "0x20058B0")]
		[Serializable]
		private struct ClickButton : IHotfixable
		{
			// Token: 0x06021251 RID: 135761 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021251")]
			[Address(RVA = "0x1B70CC0", Offset = "0x1B6F8C0", VA = "0x181B70CC0")]
			public void SetEnable(bool isEnabled)
			{
			}

			// Token: 0x0402D232 RID: 184882
			[Token(Token = "0x402D232")]
			[FieldOffset(Offset = "0x0")]
			public Button button;

			// Token: 0x0402D233 RID: 184883
			[Token(Token = "0x402D233")]
			[FieldOffset(Offset = "0x8")]
			public AudioClickPlayer clickAudio;

			// Token: 0x0402D234 RID: 184884
			[Token(Token = "0x402D234")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_SetEnable;
		}

		// Token: 0x020058B1 RID: 22705
		[Token(Token = "0x20058B1")]
		[Serializable]
		public struct UIAudioPlayer : IHotfixable
		{
			// Token: 0x06021252 RID: 135762 RVA: 0x000B8B78 File Offset: 0x000B6D78
			[Token(Token = "0x6021252")]
			[Address(RVA = "0x1B86B40", Offset = "0x1B85740", VA = "0x181B86B40")]
			public bool IsEmpty()
			{
				return default(bool);
			}

			// Token: 0x06021253 RID: 135763 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6021253")]
			[Address(RVA = "0x1B86BB0", Offset = "0x1B857B0", VA = "0x181B86BB0")]
			public Tween PlayAudio()
			{
				return null;
			}

			// Token: 0x06021254 RID: 135764 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021254")]
			[Address(RVA = "0x1B86D70", Offset = "0x1B85970", VA = "0x181B86D70")]
			private void _PlaySignalImpl()
			{
			}

			// Token: 0x0402D235 RID: 184885
			[Token(Token = "0x402D235")]
			[FieldOffset(Offset = "0x0")]
			public string signal;

			// Token: 0x0402D236 RID: 184886
			[Token(Token = "0x402D236")]
			[FieldOffset(Offset = "0x8")]
			public string subsignal;

			// Token: 0x0402D237 RID: 184887
			[Token(Token = "0x402D237")]
			[FieldOffset(Offset = "0x10")]
			public float delay;

			// Token: 0x0402D238 RID: 184888
			[Token(Token = "0x402D238")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_IsEmpty;

			// Token: 0x0402D239 RID: 184889
			[Token(Token = "0x402D239")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_PlayAudio;

			// Token: 0x0402D23A RID: 184890
			[Token(Token = "0x402D23A")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0__PlaySignalImpl;
		}

		// Token: 0x020058B2 RID: 22706
		[Token(Token = "0x20058B2")]
		public struct DisplayControl
		{
			// Token: 0x0402D23B RID: 184891
			[Token(Token = "0x402D23B")]
			[FieldOffset(Offset = "0x0")]
			public string typeWriterText;

			// Token: 0x0402D23C RID: 184892
			[Token(Token = "0x402D23C")]
			[FieldOffset(Offset = "0x8")]
			public string text;

			// Token: 0x0402D23D RID: 184893
			[Token(Token = "0x402D23D")]
			[FieldOffset(Offset = "0x10")]
			public Sprite image;

			// Token: 0x0402D23E RID: 184894
			[Token(Token = "0x402D23E")]
			[FieldOffset(Offset = "0x18")]
			public bool isObjActive;
		}

		// Token: 0x020058B3 RID: 22707
		[Token(Token = "0x20058B3")]
		private struct PlayItem : IHotfixable, IDisposable
		{
			// Token: 0x06021255 RID: 135765 RVA: 0x000B8B90 File Offset: 0x000B6D90
			[Token(Token = "0x6021255")]
			[Address(RVA = "0x1B79FE0", Offset = "0x1B78BE0", VA = "0x181B79FE0")]
			public bool IsPlaying()
			{
				return default(bool);
			}

			// Token: 0x06021256 RID: 135766 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6021256")]
			[Address(RVA = "0x1B79F20", Offset = "0x1B78B20", VA = "0x181B79F20", Slot = "4")]
			public void Dispose()
			{
			}

			// Token: 0x0402D23F RID: 184895
			[Token(Token = "0x402D23F")]
			[FieldOffset(Offset = "0x0")]
			public Tween tween;

			// Token: 0x0402D240 RID: 184896
			[Token(Token = "0x402D240")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_IsPlaying;

			// Token: 0x0402D241 RID: 184897
			[Token(Token = "0x402D241")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_Dispose;
		}
	}
}
