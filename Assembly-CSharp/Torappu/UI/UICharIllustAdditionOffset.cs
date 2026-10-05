using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI
{
	// Token: 0x0200355B RID: 13659
	[Token(Token = "0x200355B")]
	[RequireComponent(typeof(RectTransform))]
	public class UICharIllustAdditionOffset : MonoBehaviour
	{
		// Token: 0x06015C4B RID: 89163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015C4B")]
		[Address(RVA = "0xE47760", Offset = "0xE46360", VA = "0x180E47760")]
		public void ApplySkinOffset()
		{
		}

		// Token: 0x06015C4C RID: 89164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015C4C")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public UICharIllustAdditionOffset()
		{
		}

		// Token: 0x0401A2D9 RID: 107225
		[Token(Token = "0x401A2D9")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[HideInInspector]
		private UICharIllustAdditionOffset.Offset _skinOffset;

		// Token: 0x0200355C RID: 13660
		[Token(Token = "0x200355C")]
		[Serializable]
		public struct Offset
		{
			// Token: 0x0401A2DA RID: 107226
			[Token(Token = "0x401A2DA")]
			[FieldOffset(Offset = "0x0")]
			public bool enablePos;

			// Token: 0x0401A2DB RID: 107227
			[Token(Token = "0x401A2DB")]
			[FieldOffset(Offset = "0x4")]
			public Vector2 position;

			// Token: 0x0401A2DC RID: 107228
			[Token(Token = "0x401A2DC")]
			[FieldOffset(Offset = "0xC")]
			public bool enableSize;

			// Token: 0x0401A2DD RID: 107229
			[Token(Token = "0x401A2DD")]
			[FieldOffset(Offset = "0x10")]
			public Vector2 size;
		}
	}
}
