using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.DataBind
{
	// Token: 0x02001489 RID: 5257
	[Token(Token = "0x2001489")]
	[Serializable]
	public class BindPosition
	{
		// Token: 0x06007995 RID: 31125 RVA: 0x000369F0 File Offset: 0x00034BF0
		[Token(Token = "0x6007995")]
		[Address(RVA = "0x2636890", Offset = "0x2635490", VA = "0x182636890")]
		public bool IsEmpty()
		{
			return default(bool);
		}

		// Token: 0x06007996 RID: 31126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007996")]
		[Address(RVA = "0x2636810", Offset = "0x2635410", VA = "0x182636810")]
		public void Clear()
		{
		}

		// Token: 0x06007997 RID: 31127 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007997")]
		[Address(RVA = "0x2636950", Offset = "0x2635550", VA = "0x182636950", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06007998 RID: 31128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007998")]
		[Address(RVA = "0x2636C50", Offset = "0x2635850", VA = "0x182636C50")]
		public BindPosition()
		{
		}

		// Token: 0x040077C5 RID: 30661
		[Token(Token = "0x40077C5")]
		[FieldOffset(Offset = "0x10")]
		public bool isDynamic;

		// Token: 0x040077C6 RID: 30662
		[Token(Token = "0x40077C6")]
		[FieldOffset(Offset = "0x18")]
		public GameObject bindGameObject;

		// Token: 0x040077C7 RID: 30663
		[Token(Token = "0x40077C7")]
		[FieldOffset(Offset = "0x20")]
		public MonoBehaviour bindComponent;

		// Token: 0x040077C8 RID: 30664
		[Token(Token = "0x40077C8")]
		[FieldOffset(Offset = "0x28")]
		public string bindFieldName;

		// Token: 0x040077C9 RID: 30665
		[Token(Token = "0x40077C9")]
		[FieldOffset(Offset = "0x30")]
		public int bindListIndex;

		// Token: 0x040077CA RID: 30666
		[Token(Token = "0x40077CA")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		[HideInInspector]
		private bool isBindList;
	}
}
