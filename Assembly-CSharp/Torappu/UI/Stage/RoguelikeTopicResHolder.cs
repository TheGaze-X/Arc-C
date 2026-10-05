using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x020067FC RID: 26620
	[Token(Token = "0x20067FC")]
	public class RoguelikeTopicResHolder : MonoBehaviour, IHotfixable
	{
		// Token: 0x17005A33 RID: 23091
		// (get) Token: 0x0602626B RID: 156267 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005A33")]
		public Sprite entryImg
		{
			[Token(Token = "0x602626B")]
			[Address(RVA = "0x2133DE0", Offset = "0x21329E0", VA = "0x182133DE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005A34 RID: 23092
		// (get) Token: 0x0602626C RID: 156268 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005A34")]
		public Sprite backImg
		{
			[Token(Token = "0x602626C")]
			[Address(RVA = "0x2133D10", Offset = "0x2132910", VA = "0x182133D10")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005A35 RID: 23093
		// (get) Token: 0x0602626D RID: 156269 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005A35")]
		public Sprite permModeEntryImg
		{
			[Token(Token = "0x602626D")]
			[Address(RVA = "0x2133EB0", Offset = "0x2132AB0", VA = "0x182133EB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005A36 RID: 23094
		// (get) Token: 0x0602626E RID: 156270 RVA: 0x000CA338 File Offset: 0x000C8538
		[Token(Token = "0x17005A36")]
		public Color themeColor
		{
			[Token(Token = "0x602626E")]
			[Address(RVA = "0x2133F80", Offset = "0x2132B80", VA = "0x182133F80")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x0602626F RID: 156271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602626F")]
		[Address(RVA = "0x2133CA0", Offset = "0x21328A0", VA = "0x182133CA0")]
		public RoguelikeTopicResHolder()
		{
		}

		// Token: 0x04035BB9 RID: 220089
		[Token(Token = "0x4035BB9")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Sprite _entryImg;

		// Token: 0x04035BBA RID: 220090
		[Token(Token = "0x4035BBA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Sprite _backImg;

		// Token: 0x04035BBB RID: 220091
		[Token(Token = "0x4035BBB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Sprite _permModeEntryImg;

		// Token: 0x04035BBC RID: 220092
		[Token(Token = "0x4035BBC")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Color _themeColor;

		// Token: 0x04035BBD RID: 220093
		[Token(Token = "0x4035BBD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_entryImg;

		// Token: 0x04035BBE RID: 220094
		[Token(Token = "0x4035BBE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_backImg;

		// Token: 0x04035BBF RID: 220095
		[Token(Token = "0x4035BBF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_permModeEntryImg;

		// Token: 0x04035BC0 RID: 220096
		[Token(Token = "0x4035BC0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_themeColor;

		// Token: 0x04035BC1 RID: 220097
		[Token(Token = "0x4035BC1")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
