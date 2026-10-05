using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act3D0
{
	// Token: 0x0200741A RID: 29722
	[Token(Token = "0x200741A")]
	public class Act3D0ClueHolder : MonoBehaviour, IHotfixable
	{
		// Token: 0x06029F71 RID: 171889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029F71")]
		[Address(RVA = "0x2586490", Offset = "0x2585090", VA = "0x182586490")]
		public void Render(List<Act3D0ClueInfo> clueInfo)
		{
		}

		// Token: 0x06029F72 RID: 171890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029F72")]
		[Address(RVA = "0x25867D0", Offset = "0x25853D0", VA = "0x1825867D0")]
		public void SetSelectId()
		{
		}

		// Token: 0x06029F73 RID: 171891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029F73")]
		[Address(RVA = "0x2586290", Offset = "0x2584E90", VA = "0x182586290")]
		public void RefreshImg()
		{
		}

		// Token: 0x06029F74 RID: 171892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029F74")]
		[Address(RVA = "0x2586070", Offset = "0x2584C70", VA = "0x182586070")]
		public void AddOne()
		{
		}

		// Token: 0x06029F75 RID: 171893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029F75")]
		[Address(RVA = "0x2586190", Offset = "0x2584D90", VA = "0x182586190")]
		public void MinusOne()
		{
		}

		// Token: 0x06029F76 RID: 171894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029F76")]
		[Address(RVA = "0x2586970", Offset = "0x2585570", VA = "0x182586970")]
		public Act3D0ClueHolder()
		{
		}

		// Token: 0x0403C27D RID: 246397
		[Token(Token = "0x403C27D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _focusSprite;

		// Token: 0x0403C27E RID: 246398
		[Token(Token = "0x403C27E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _focusObj;

		// Token: 0x0403C27F RID: 246399
		[Token(Token = "0x403C27F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _noObj;

		// Token: 0x0403C280 RID: 246400
		[Token(Token = "0x403C280")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Act3D0ClueSliderObj _slideObj;

		// Token: 0x0403C281 RID: 246401
		[Token(Token = "0x403C281")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Transform _container;

		// Token: 0x0403C282 RID: 246402
		[Token(Token = "0x403C282")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _leftPart;

		// Token: 0x0403C283 RID: 246403
		[Token(Token = "0x403C283")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _rightPart;

		// Token: 0x0403C284 RID: 246404
		[Token(Token = "0x403C284")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Animator _animator;

		// Token: 0x0403C285 RID: 246405
		[Token(Token = "0x403C285")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _countText;

		// Token: 0x0403C286 RID: 246406
		[Token(Token = "0x403C286")]
		[FieldOffset(Offset = "0x60")]
		[NonSerialized]
		public int selectId;

		// Token: 0x0403C287 RID: 246407
		[Token(Token = "0x403C287")]
		[FieldOffset(Offset = "0x68")]
		private List<Act3D0ClueInfo> m_cacheInfo;

		// Token: 0x0403C288 RID: 246408
		[Token(Token = "0x403C288")]
		[FieldOffset(Offset = "0x70")]
		private List<Act3D0ClueSliderObj> m_slideObj;

		// Token: 0x0403C289 RID: 246409
		[Token(Token = "0x403C289")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403C28A RID: 246410
		[Token(Token = "0x403C28A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetSelectId;

		// Token: 0x0403C28B RID: 246411
		[Token(Token = "0x403C28B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RefreshImg;

		// Token: 0x0403C28C RID: 246412
		[Token(Token = "0x403C28C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_AddOne;

		// Token: 0x0403C28D RID: 246413
		[Token(Token = "0x403C28D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_MinusOne;

		// Token: 0x0403C28E RID: 246414
		[Token(Token = "0x403C28E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
