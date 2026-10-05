using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Building.DIY.Test
{
	// Token: 0x0200192B RID: 6443
	[Token(Token = "0x200192B")]
	public class MockFurnitureSaver : MonoBehaviour, IFurnitureSaver
	{
		// Token: 0x0600A23E RID: 41534 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A23E")]
		[Address(RVA = "0x31D14D0", Offset = "0x31D00D0", VA = "0x1831D14D0")]
		private IEnumerator _ResultCoroutine(Action<int> resultHandler, int result)
		{
			return null;
		}

		// Token: 0x0600A23F RID: 41535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A23F")]
		[Address(RVA = "0x31D0B50", Offset = "0x31CF750", VA = "0x1831D0B50", Slot = "4")]
		public void SaveFurniture(int index, IFurnitureProvider furnitureSource, IDIYRoomModifierProvider modifierSource, IFurnitureManager furnitureTarget, IDIYRoomModifierManager modifierTarget, Action<int> resultHandler)
		{
		}

		// Token: 0x0600A240 RID: 41536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A240")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "5")]
		public void RefreshFurniture()
		{
		}

		// Token: 0x0600A241 RID: 41537 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A241")]
		[Address(RVA = "0x31D1570", Offset = "0x31D0170", VA = "0x1831D1570")]
		public MockFurnitureSaver()
		{
		}

		// Token: 0x0400988B RID: 39051
		[Token(Token = "0x400988B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _fakeDelay;
	}
}
