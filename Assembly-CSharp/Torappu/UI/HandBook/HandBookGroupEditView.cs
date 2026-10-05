using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI.HandBook
{
	// Token: 0x020066E4 RID: 26340
	[Token(Token = "0x20066E4")]
	public class HandBookGroupEditView : MonoBehaviour
	{
		// Token: 0x17005991 RID: 22929
		// (get) Token: 0x06025CCE RID: 154830 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005991")]
		public Dictionary<string, string> npcPair
		{
			[Token(Token = "0x6025CCE")]
			[Address(RVA = "0x20BC2E0", Offset = "0x20BAEE0", VA = "0x1820BC2E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06025CCF RID: 154831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025CCF")]
		[Address(RVA = "0x20BC170", Offset = "0x20BAD70", VA = "0x1820BC170")]
		private void Start()
		{
		}

		// Token: 0x06025CD0 RID: 154832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025CD0")]
		[Address(RVA = "0x20BBF20", Offset = "0x20BAB20", VA = "0x1820BBF20")]
		public void OnShow()
		{
		}

		// Token: 0x06025CD1 RID: 154833 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025CD1")]
		[Address(RVA = "0x20BBE60", Offset = "0x20BAA60", VA = "0x1820BBE60")]
		public string CheckIsNPCAvail(string charId)
		{
			return null;
		}

		// Token: 0x06025CD2 RID: 154834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025CD2")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		public void SaveData()
		{
		}

		// Token: 0x06025CD3 RID: 154835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025CD3")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public HandBookGroupEditView()
		{
		}

		// Token: 0x0403524E RID: 217678
		[Token(Token = "0x403524E")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<string, string> m_npcPair;

		// Token: 0x0403524F RID: 217679
		[Token(Token = "0x403524F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private HandBookV2MapPosDB _posDB;

		// Token: 0x04035250 RID: 217680
		[Token(Token = "0x4035250")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private HandBookGroupDetailEdit _edit;

		// Token: 0x04035251 RID: 217681
		[Token(Token = "0x4035251")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private InputField _inputField;

		// Token: 0x04035252 RID: 217682
		[Token(Token = "0x4035252")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private TextAsset _textAssets;

		// Token: 0x04035253 RID: 217683
		[Token(Token = "0x4035253")]
		[FieldOffset(Offset = "0x40")]
		public HandBookV2MapPosData posData;
	}
}
