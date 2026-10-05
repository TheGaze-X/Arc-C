using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Building.EditorTools
{
	// Token: 0x02001A95 RID: 6805
	[Token(Token = "0x2001A95")]
	public class BuildingLoader : MonoBehaviour
	{
		// Token: 0x0600AB7F RID: 43903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AB7F")]
		[Address(RVA = "0x327DC80", Offset = "0x327C880", VA = "0x18327DC80")]
		private void Start()
		{
		}

		// Token: 0x0600AB80 RID: 43904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AB80")]
		[Address(RVA = "0x327DB30", Offset = "0x327C730", VA = "0x18327DB30")]
		public void InitTestData()
		{
		}

		// Token: 0x0600AB81 RID: 43905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AB81")]
		[Address(RVA = "0x327DD50", Offset = "0x327C950", VA = "0x18327DD50")]
		private void _LoadBuildingForCurrentPlayer()
		{
		}

		// Token: 0x0600AB82 RID: 43906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AB82")]
		[Address(RVA = "0x327DFD0", Offset = "0x327CBD0", VA = "0x18327DFD0")]
		private void _LoadBuildingForVisiting(VisitBuildingResponse visitResponse)
		{
		}

		// Token: 0x0600AB83 RID: 43907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AB83")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public BuildingLoader()
		{
		}

		// Token: 0x0400A3B5 RID: 41909
		[Token(Token = "0x400A3B5")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string _layoutId;

		// Token: 0x0400A3B6 RID: 41910
		[Token(Token = "0x400A3B6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TextAsset _playerDataText;

		// Token: 0x0400A3B7 RID: 41911
		[Token(Token = "0x400A3B7")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool _usePlayerDataText;

		// Token: 0x0400A3B8 RID: 41912
		[Token(Token = "0x400A3B8")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TextAsset _visitBuildingText;

		// Token: 0x0400A3B9 RID: 41913
		[Token(Token = "0x400A3B9")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private bool _useVisitBuildingText;
	}
}
