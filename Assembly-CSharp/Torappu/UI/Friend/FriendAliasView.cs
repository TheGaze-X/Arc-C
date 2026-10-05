using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI.Friend
{
	// Token: 0x02004D97 RID: 19863
	[Token(Token = "0x2004D97")]
	public class FriendAliasView : MonoBehaviour
	{
		// Token: 0x0601DB7D RID: 121725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DB7D")]
		[Address(RVA = "0x173B670", Offset = "0x173A270", VA = "0x18173B670")]
		public void InitAlias(string alias, string uid)
		{
		}

		// Token: 0x0601DB7E RID: 121726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DB7E")]
		[Address(RVA = "0x173B740", Offset = "0x173A340", VA = "0x18173B740")]
		public void OnClick()
		{
		}

		// Token: 0x0601DB7F RID: 121727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DB7F")]
		[Address(RVA = "0x173B6E0", Offset = "0x173A2E0", VA = "0x18173B6E0")]
		public void OnCancel()
		{
		}

		// Token: 0x0601DB80 RID: 121728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DB80")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public FriendAliasView()
		{
		}

		// Token: 0x04027475 RID: 160885
		[Token(Token = "0x4027475")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private InputField _alias;

		// Token: 0x04027476 RID: 160886
		[Token(Token = "0x4027476")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private FriendListState _state;

		// Token: 0x04027477 RID: 160887
		[Token(Token = "0x4027477")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIRenderTextureImage _blurBack;

		// Token: 0x04027478 RID: 160888
		[Token(Token = "0x4027478")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Shader _blurShader;

		// Token: 0x04027479 RID: 160889
		[Token(Token = "0x4027479")]
		[FieldOffset(Offset = "0x38")]
		private string m_uid;
	}
}
