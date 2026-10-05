using System;
using System.Collections;
using Il2CppDummyDll;
using Torappu.AVG;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Tuning
{
	// Token: 0x02003C59 RID: 15449
	[Token(Token = "0x2003C59")]
	public class TuningChatDialogComp : TuningChatFadeCompBase
	{
		// Token: 0x06018249 RID: 98889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018249")]
		[Address(RVA = "0x1090200", Offset = "0x108EE00", VA = "0x181090200")]
		private void _Render(string style)
		{
		}

		// Token: 0x0601824A RID: 98890 RVA: 0x00099888 File Offset: 0x00097A88
		[Token(Token = "0x601824A")]
		[Address(RVA = "0x108FE30", Offset = "0x108EA30", VA = "0x18108FE30")]
		private float _GetPreferedHeight(TuningChatDialogComp.Options options)
		{
			return 0f;
		}

		// Token: 0x0601824B RID: 98891 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601824B")]
		[Address(RVA = "0x108FCD0", Offset = "0x108E8D0", VA = "0x18108FCD0")]
		private string _GetContent(string content, string style)
		{
			return null;
		}

		// Token: 0x0601824C RID: 98892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601824C")]
		[Address(RVA = "0x1090340", Offset = "0x108EF40", VA = "0x181090340")]
		public TuningChatDialogComp()
		{
		}

		// Token: 0x0401D5A3 RID: 120227
		[Token(Token = "0x401D5A3")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _content;

		// Token: 0x0401D5A4 RID: 120228
		[Token(Token = "0x401D5A4")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private AVGTypeWriterText _typeWriter;

		// Token: 0x0401D5A5 RID: 120229
		[Token(Token = "0x401D5A5")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Color _askColor;

		// Token: 0x0401D5A6 RID: 120230
		[Token(Token = "0x401D5A6")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Color _answerColor;

		// Token: 0x0401D5A7 RID: 120231
		[Token(Token = "0x401D5A7")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Color _defaultColor;

		// Token: 0x0401D5A8 RID: 120232
		[Token(Token = "0x401D5A8")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private float _padding;

		// Token: 0x0401D5A9 RID: 120233
		[Token(Token = "0x401D5A9")]
		[FieldOffset(Offset = "0x78")]
		private string m_cachedContent;

		// Token: 0x0401D5AA RID: 120234
		[Token(Token = "0x401D5AA")]
		[FieldOffset(Offset = "0x80")]
		private TextGenerator m_textGenerator;

		// Token: 0x0401D5AB RID: 120235
		[Token(Token = "0x401D5AB")]
		[FieldOffset(Offset = "0x88")]
		private TextGenerationSettings m_textSettings;

		// Token: 0x0401D5AC RID: 120236
		[Token(Token = "0x401D5AC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__Render;

		// Token: 0x0401D5AD RID: 120237
		[Token(Token = "0x401D5AD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__GetPreferedHeight;

		// Token: 0x0401D5AE RID: 120238
		[Token(Token = "0x401D5AE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__GetContent;

		// Token: 0x0401D5AF RID: 120239
		[Token(Token = "0x401D5AF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003C5A RID: 15450
		[Token(Token = "0x2003C5A")]
		public struct Options
		{
			// Token: 0x0401D5B0 RID: 120240
			[Token(Token = "0x401D5B0")]
			[FieldOffset(Offset = "0x0")]
			public TuningChatDialogComp prefab;

			// Token: 0x0401D5B1 RID: 120241
			[Token(Token = "0x401D5B1")]
			[FieldOffset(Offset = "0x8")]
			public string text;

			// Token: 0x0401D5B2 RID: 120242
			[Token(Token = "0x401D5B2")]
			[FieldOffset(Offset = "0x10")]
			public string style;

			// Token: 0x0401D5B3 RID: 120243
			[Token(Token = "0x401D5B3")]
			[FieldOffset(Offset = "0x18")]
			public Text demiText;
		}

		// Token: 0x02003C5B RID: 15451
		[Token(Token = "0x2003C5B")]
		public class VirtualView : TuningChatFadeCompBase.VirtualViewBase<TuningChatDialogComp>
		{
			// Token: 0x0601824D RID: 98893 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601824D")]
			[Address(RVA = "0x10A3B40", Offset = "0x10A2740", VA = "0x1810A3B40")]
			public VirtualView(TuningChatDialogComp.Options options)
			{
			}

			// Token: 0x0601824E RID: 98894 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601824E")]
			[Address(RVA = "0x10A36B0", Offset = "0x10A22B0", VA = "0x1810A36B0", Slot = "22")]
			protected override void OnUpdateView(TuningChatDialogComp view)
			{
			}

			// Token: 0x0601824F RID: 98895 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601824F")]
			[Address(RVA = "0x10A3470", Offset = "0x10A2070", VA = "0x1810A3470", Slot = "28")]
			protected override void BeforePlayFade(TuningChatDialogComp view)
			{
			}

			// Token: 0x06018250 RID: 98896 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6018250")]
			[Address(RVA = "0x10A3A10", Offset = "0x10A2610", VA = "0x1810A3A10", Slot = "29")]
			protected override IEnumerator PlayView(TuningChatDialogComp view)
			{
				return null;
			}

			// Token: 0x06018251 RID: 98897 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6018251")]
			[Address(RVA = "0x10A35B0", Offset = "0x10A21B0", VA = "0x1810A35B0", Slot = "26")]
			protected override TuningChatDialogComp FadePrefab()
			{
				return null;
			}

			// Token: 0x06018252 RID: 98898 RVA: 0x000998A0 File Offset: 0x00097AA0
			[Token(Token = "0x6018252")]
			[Address(RVA = "0x10A3610", Offset = "0x10A2210", VA = "0x1810A3610", Slot = "27")]
			protected override float GetPreferedHeight()
			{
				return 0f;
			}

			// Token: 0x0401D5B4 RID: 120244
			[Token(Token = "0x401D5B4")]
			[FieldOffset(Offset = "0x38")]
			private TuningChatDialogComp.Options m_options;

			// Token: 0x0401D5B5 RID: 120245
			[Token(Token = "0x401D5B5")]
			[FieldOffset(Offset = "0x58")]
			private float m_cachedSize;

			// Token: 0x0401D5B6 RID: 120246
			[Token(Token = "0x401D5B6")]
			[FieldOffset(Offset = "0x60")]
			private string m_dialogContent;

			// Token: 0x0401D5B7 RID: 120247
			[Token(Token = "0x401D5B7")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401D5B8 RID: 120248
			[Token(Token = "0x401D5B8")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_OnUpdateView;

			// Token: 0x0401D5B9 RID: 120249
			[Token(Token = "0x401D5B9")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_BeforePlayFade;

			// Token: 0x0401D5BA RID: 120250
			[Token(Token = "0x401D5BA")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_PlayView;

			// Token: 0x0401D5BB RID: 120251
			[Token(Token = "0x401D5BB")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_FadePrefab;

			// Token: 0x0401D5BC RID: 120252
			[Token(Token = "0x401D5BC")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_GetPreferedHeight;
		}
	}
}
