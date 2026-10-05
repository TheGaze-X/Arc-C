using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act36side
{
	// Token: 0x02007458 RID: 29784
	[Token(Token = "0x2007458")]
	public class Act36sideFoodHandbookEnemyListItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602A058 RID: 172120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A058")]
		[Address(RVA = "0x259BEE0", Offset = "0x259AAE0", VA = "0x18259BEE0")]
		public void Render(Act36sideFoodHandbookEnemyItemModel model, string actId)
		{
		}

		// Token: 0x0602A059 RID: 172121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A059")]
		[Address(RVA = "0x259C160", Offset = "0x259AD60", VA = "0x18259C160")]
		public Act36sideFoodHandbookEnemyListItem()
		{
		}

		// Token: 0x0403C456 RID: 246870
		[Token(Token = "0x403C456")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAtlasImage _foodType;

		// Token: 0x0403C457 RID: 246871
		[Token(Token = "0x403C457")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAtlasImage _foodAmount;

		// Token: 0x0403C458 RID: 246872
		[Token(Token = "0x403C458")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _foodName;

		// Token: 0x0403C459 RID: 246873
		[Token(Token = "0x403C459")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _foodIcon;

		// Token: 0x0403C45A RID: 246874
		[Token(Token = "0x403C45A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _foodDesc;

		// Token: 0x0403C45B RID: 246875
		[Token(Token = "0x403C45B")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _newObject;

		// Token: 0x0403C45C RID: 246876
		[Token(Token = "0x403C45C")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private TwoStateToggle _unlockToggle;

		// Token: 0x0403C45D RID: 246877
		[Token(Token = "0x403C45D")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UIAtlasObject _atlasObj;

		// Token: 0x0403C45E RID: 246878
		[Token(Token = "0x403C45E")]
		[FieldOffset(Offset = "0x58")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0403C45F RID: 246879
		[Token(Token = "0x403C45F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403C460 RID: 246880
		[Token(Token = "0x403C460")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
