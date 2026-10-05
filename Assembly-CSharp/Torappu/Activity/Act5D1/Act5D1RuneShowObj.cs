using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act5D1
{
	// Token: 0x02007231 RID: 29233
	[Token(Token = "0x2007231")]
	public class Act5D1RuneShowObj : MonoBehaviour, IHotfixable
	{
		// Token: 0x060296DD RID: 169693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60296DD")]
		[Address(RVA = "0x24CA9D0", Offset = "0x24C95D0", VA = "0x1824CA9D0")]
		public void ApplyData(string stageId, string runeId, bool canUnlock = false)
		{
		}

		// Token: 0x060296DE RID: 169694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60296DE")]
		[Address(RVA = "0x24CAE80", Offset = "0x24C9A80", VA = "0x1824CAE80")]
		public Act5D1RuneShowObj()
		{
		}

		// Token: 0x0403B2D0 RID: 242384
		[Token(Token = "0x403B2D0")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _runeName;

		// Token: 0x0403B2D1 RID: 242385
		[Token(Token = "0x403B2D1")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _runeIcon;

		// Token: 0x0403B2D2 RID: 242386
		[Token(Token = "0x403B2D2")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _runePoint;

		// Token: 0x0403B2D3 RID: 242387
		[Token(Token = "0x403B2D3")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _runeDetail;

		// Token: 0x0403B2D4 RID: 242388
		[Token(Token = "0x403B2D4")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _runeDescription;

		// Token: 0x0403B2D5 RID: 242389
		[Token(Token = "0x403B2D5")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _runeLockedInfo;

		// Token: 0x0403B2D6 RID: 242390
		[Token(Token = "0x403B2D6")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _runeLocked;

		// Token: 0x0403B2D7 RID: 242391
		[Token(Token = "0x403B2D7")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _pointPart;

		// Token: 0x0403B2D8 RID: 242392
		[Token(Token = "0x403B2D8")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _newHandPoint;

		// Token: 0x0403B2D9 RID: 242393
		[Token(Token = "0x403B2D9")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _runeUnlockCannotBuy;

		// Token: 0x0403B2DA RID: 242394
		[Token(Token = "0x403B2DA")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Image _backImage;

		// Token: 0x0403B2DB RID: 242395
		[Token(Token = "0x403B2DB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ApplyData;

		// Token: 0x0403B2DC RID: 242396
		[Token(Token = "0x403B2DC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
