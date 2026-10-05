using System;
using System.Collections;
using Il2CppDummyDll;
using Torappu.AVG;
using UnityEngine;
using XLua;

namespace Torappu.Gacha
{
	// Token: 0x0200165E RID: 5726
	[Token(Token = "0x200165E")]
	[RequireComponent(typeof(CanvasGroup))]
	public class PanelCharacterDialog : MonoBehaviour, IHotfixable
	{
		// Token: 0x17000F6C RID: 3948
		// (get) Token: 0x060081EC RID: 33260 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F6C")]
		private CanvasGroup canvasGroup
		{
			[Token(Token = "0x60081EC")]
			[Address(RVA = "0x2B09A10", Offset = "0x2B08610", VA = "0x182B09A10")]
			get
			{
				return null;
			}
		}

		// Token: 0x060081ED RID: 33261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60081ED")]
		[Address(RVA = "0x2B09180", Offset = "0x2B07D80", VA = "0x182B09180")]
		public void Reset()
		{
		}

		// Token: 0x060081EE RID: 33262 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60081EE")]
		[Address(RVA = "0x2B09570", Offset = "0x2B08170", VA = "0x182B09570")]
		private string _InitDialog(GachaController.CharacterConfig config)
		{
			return null;
		}

		// Token: 0x060081EF RID: 33263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60081EF")]
		[Address(RVA = "0x2B09200", Offset = "0x2B07E00", VA = "0x182B09200")]
		public void SkipToEnd(GachaController.CharacterConfig config)
		{
		}

		// Token: 0x060081F0 RID: 33264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60081F0")]
		[Address(RVA = "0x2B09460", Offset = "0x2B08060", VA = "0x182B09460")]
		private void _AdjustMessageRect()
		{
		}

		// Token: 0x060081F1 RID: 33265 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60081F1")]
		[Address(RVA = "0x2B098F0", Offset = "0x2B084F0", VA = "0x182B098F0")]
		private IEnumerator _TryFinishText()
		{
			return null;
		}

		// Token: 0x060081F2 RID: 33266 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60081F2")]
		[Address(RVA = "0x2B09040", Offset = "0x2B07C40", VA = "0x182B09040")]
		public IEnumerator Begin(GachaController.CharacterConfig charConfig)
		{
			return null;
		}

		// Token: 0x060081F3 RID: 33267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60081F3")]
		[Address(RVA = "0x2B08F80", Offset = "0x2B07B80", VA = "0x182B08F80")]
		private void Awake()
		{
		}

		// Token: 0x060081F4 RID: 33268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60081F4")]
		[Address(RVA = "0x2B099A0", Offset = "0x2B085A0", VA = "0x182B099A0")]
		public PanelCharacterDialog()
		{
		}

		// Token: 0x040083F8 RID: 33784
		[Token(Token = "0x40083F8")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _fadeinTime;

		// Token: 0x040083F9 RID: 33785
		[Token(Token = "0x40083F9")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AVGTypeWriterText _text;

		// Token: 0x040083FA RID: 33786
		[Token(Token = "0x40083FA")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _messageRect;

		// Token: 0x040083FB RID: 33787
		[Token(Token = "0x40083FB")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _messageRectBottomPadding;

		// Token: 0x040083FC RID: 33788
		[Token(Token = "0x40083FC")]
		private const float TRY_FINISH_TIME = 0.2f;

		// Token: 0x040083FD RID: 33789
		[Token(Token = "0x40083FD")]
		[FieldOffset(Offset = "0x34")]
		private bool m_waitSignal;

		// Token: 0x040083FE RID: 33790
		[Token(Token = "0x40083FE")]
		[FieldOffset(Offset = "0x38")]
		private CanvasGroup m_canvasGroup;

		// Token: 0x040083FF RID: 33791
		[Token(Token = "0x40083FF")]
		[FieldOffset(Offset = "0x40")]
		private float m_originYPos;

		// Token: 0x04008400 RID: 33792
		[Token(Token = "0x4008400")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_canvasGroup;

		// Token: 0x04008401 RID: 33793
		[Token(Token = "0x4008401")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x04008402 RID: 33794
		[Token(Token = "0x4008402")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitDialog;

		// Token: 0x04008403 RID: 33795
		[Token(Token = "0x4008403")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SkipToEnd;

		// Token: 0x04008404 RID: 33796
		[Token(Token = "0x4008404")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__AdjustMessageRect;

		// Token: 0x04008405 RID: 33797
		[Token(Token = "0x4008405")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__TryFinishText;

		// Token: 0x04008406 RID: 33798
		[Token(Token = "0x4008406")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_Begin;

		// Token: 0x04008407 RID: 33799
		[Token(Token = "0x4008407")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x04008408 RID: 33800
		[Token(Token = "0x4008408")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
