using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI.Shop
{
	// Token: 0x02005B46 RID: 23366
	[Token(Token = "0x2005B46")]
	[RequireComponent(typeof(CanvasGroup))]
	public class ShopKeeperDialog : MonoBehaviour
	{
		// Token: 0x17004F66 RID: 20326
		// (get) Token: 0x06021ECD RID: 138957 RVA: 0x000BBC38 File Offset: 0x000B9E38
		// (set) Token: 0x06021ECE RID: 138958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004F66")]
		public bool isShown
		{
			[Token(Token = "0x6021ECD")]
			[Address(RVA = "0x1C638E0", Offset = "0x1C624E0", VA = "0x181C638E0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6021ECE")]
			[Address(RVA = "0x1C63910", Offset = "0x1C62510", VA = "0x181C63910")]
			set
			{
			}
		}

		// Token: 0x17004F67 RID: 20327
		// (get) Token: 0x06021ECF RID: 138959 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06021ED0 RID: 138960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004F67")]
		public ShopKeeperWord currentWord
		{
			[Token(Token = "0x6021ECF")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6021ED0")]
			[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004F68 RID: 20328
		// (get) Token: 0x06021ED1 RID: 138961 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004F68")]
		private CanvasGroup canvasGroup
		{
			[Token(Token = "0x6021ED1")]
			[Address(RVA = "0x1C63720", Offset = "0x1C62320", VA = "0x181C63720")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004F69 RID: 20329
		// (get) Token: 0x06021ED2 RID: 138962 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004F69")]
		private FadeSwitchTween fadeSwitchTween
		{
			[Token(Token = "0x6021ED2")]
			[Address(RVA = "0x1C637C0", Offset = "0x1C623C0", VA = "0x181C637C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06021ED3 RID: 138963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021ED3")]
		[Address(RVA = "0x1C635A0", Offset = "0x1C621A0", VA = "0x181C635A0")]
		public void SetData(ShopKeeperWord word, bool force = false)
		{
		}

		// Token: 0x06021ED4 RID: 138964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021ED4")]
		[Address(RVA = "0x1C63690", Offset = "0x1C62290", VA = "0x181C63690")]
		private void _UpdateShown(bool value, bool force)
		{
		}

		// Token: 0x06021ED5 RID: 138965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021ED5")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public ShopKeeperDialog()
		{
		}

		// Token: 0x0402E7B0 RID: 190384
		[Token(Token = "0x402E7B0")]
		private const float FADE_DURATION = 0.23f;

		// Token: 0x0402E7B1 RID: 190385
		[Token(Token = "0x402E7B1")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _text;

		// Token: 0x0402E7B3 RID: 190387
		[Token(Token = "0x402E7B3")]
		[FieldOffset(Offset = "0x28")]
		private CanvasGroup m_canvasGroup;

		// Token: 0x0402E7B4 RID: 190388
		[Token(Token = "0x402E7B4")]
		[FieldOffset(Offset = "0x30")]
		private FadeSwitchTween m_fadeSwitchTween;
	}
}
