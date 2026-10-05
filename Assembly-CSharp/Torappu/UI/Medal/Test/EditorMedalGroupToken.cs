using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI.Medal.Test
{
	// Token: 0x020049B1 RID: 18865
	[Token(Token = "0x20049B1")]
	public class EditorMedalGroupToken : MonoBehaviour
	{
		// Token: 0x0601C6D2 RID: 116434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C6D2")]
		[Address(RVA = "0x15DDF90", Offset = "0x15DCB90", VA = "0x1815DDF90")]
		public EditorMedalGroupToken()
		{
		}

		// Token: 0x040253CF RID: 152527
		[Token(Token = "0x40253CF")]
		private const string ASSET_PATH = "Assets/Torappu/Prefabs/UI/Medal/Test/editor_medal_group_token.prefab";

		// Token: 0x040253D0 RID: 152528
		[Token(Token = "0x40253D0")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string _medalId;

		// Token: 0x040253D1 RID: 152529
		[Token(Token = "0x40253D1")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _icon;

		// Token: 0x040253D2 RID: 152530
		[Token(Token = "0x40253D2")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[ReadOnly]
		private MedalSize _size;
	}
}
