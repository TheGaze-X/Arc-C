using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x02004564 RID: 17764
	[Token(Token = "0x2004564")]
	[CreateAssetMenu(menuName = "Torappu/Roguelike/Theme")]
	public class RoguelikeTopicTheme : ScriptableObject, IHotfixable
	{
		// Token: 0x0601B11A RID: 110874 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601B11A")]
		public T GetStyle<T>() where T : RoguelikeTopicStyle
		{
			return null;
		}

		// Token: 0x0601B11B RID: 110875 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601B11B")]
		public T GetStyleNotNull<T>() where T : RoguelikeTopicStyle
		{
			return null;
		}

		// Token: 0x0601B11C RID: 110876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B11C")]
		[Address(RVA = "0x14409C0", Offset = "0x143F5C0", VA = "0x1814409C0")]
		public RoguelikeTopicTheme()
		{
		}

		// Token: 0x04022CA7 RID: 142503
		[Token(Token = "0x4022CA7")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RoguelikeTopicStyle[] _styles;

		// Token: 0x04022CA8 RID: 142504
		[Token(Token = "0x4022CA8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetStyle;

		// Token: 0x04022CA9 RID: 142505
		[Token(Token = "0x4022CA9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetStyleNotNull;

		// Token: 0x04022CAA RID: 142506
		[Token(Token = "0x4022CAA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
