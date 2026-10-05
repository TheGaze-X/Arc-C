using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Activity
{
	// Token: 0x02006D62 RID: 28002
	[Token(Token = "0x2006D62")]
	public class ActivityGameObjectAssetHolder : ActivityAssetHolder
	{
		// Token: 0x06027E85 RID: 163461 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027E85")]
		[Address(RVA = "0x233C0E0", Offset = "0x233ACE0", VA = "0x18233C0E0", Slot = "4")]
		public override string[] GetAssetIdList()
		{
			return null;
		}

		// Token: 0x06027E86 RID: 163462 RVA: 0x000CFEA0 File Offset: 0x000CE0A0
		[Token(Token = "0x6027E86")]
		[Address(RVA = "0x233C290", Offset = "0x233AE90", VA = "0x18233C290")]
		public bool TryFindGameObject(string id, out GameObject gameObject)
		{
			return default(bool);
		}

		// Token: 0x06027E87 RID: 163463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027E87")]
		[Address(RVA = "0x233C3F0", Offset = "0x233AFF0", VA = "0x18233C3F0")]
		public ActivityGameObjectAssetHolder()
		{
		}

		// Token: 0x04038910 RID: 231696
		[Token(Token = "0x4038910")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject[] _gameObjectList;

		// Token: 0x04038911 RID: 231697
		[Token(Token = "0x4038911")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetAssetIdList;

		// Token: 0x04038912 RID: 231698
		[Token(Token = "0x4038912")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_TryFindGameObject;

		// Token: 0x04038913 RID: 231699
		[Token(Token = "0x4038913")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
