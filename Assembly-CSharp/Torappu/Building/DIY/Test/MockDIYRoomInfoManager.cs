using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Building.DIY.Test
{
	// Token: 0x02001905 RID: 6405
	[Token(Token = "0x2001905")]
	public class MockDIYRoomInfoManager : MonoBehaviour, IDIYRoomInfoProvider
	{
		// Token: 0x0600A162 RID: 41314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A162")]
		[Address(RVA = "0x31CBEA0", Offset = "0x31CAAA0", VA = "0x1831CBEA0")]
		private void Awake()
		{
		}

		// Token: 0x0600A163 RID: 41315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A163")]
		[Address(RVA = "0x31CC080", Offset = "0x31CAC80", VA = "0x1831CC080", Slot = "4")]
		public void QueryData(Predicate<DIYRoomInfo> filter, Action<DIYRoomInfo> action)
		{
		}

		// Token: 0x0600A164 RID: 41316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A164")]
		[Address(RVA = "0x31CC170", Offset = "0x31CAD70", VA = "0x1831CC170", Slot = "5")]
		public void QueryDatas(Predicate<DIYRoomInfo> filter, Action<DIYRoomInfo> action)
		{
		}

		// Token: 0x0600A165 RID: 41317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A165")]
		[Address(RVA = "0x31CC260", Offset = "0x31CAE60", VA = "0x1831CC260")]
		public MockDIYRoomInfoManager()
		{
		}

		// Token: 0x040097A6 RID: 38822
		[Token(Token = "0x40097A6")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string[] _templateIds;

		// Token: 0x040097A7 RID: 38823
		[Token(Token = "0x40097A7")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private MockDIYRoomTemplateDB _templateDB;

		// Token: 0x040097A8 RID: 38824
		[Token(Token = "0x40097A8")]
		[FieldOffset(Offset = "0x28")]
		private List<DIYRoomInfo> m_DIYRoomInfoList;
	}
}
