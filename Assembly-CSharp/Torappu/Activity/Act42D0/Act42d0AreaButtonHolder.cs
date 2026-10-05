using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act42D0
{
	// Token: 0x0200738F RID: 29583
	[Token(Token = "0x200738F")]
	public class Act42d0AreaButtonHolder : MonoBehaviour, IHotfixable
	{
		// Token: 0x06029D1F RID: 171295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029D1F")]
		[Address(RVA = "0x2576C30", Offset = "0x2575830", VA = "0x182576C30")]
		public void Render(Act42d0AreaViewModel viewModel, bool isSelected, NewestProgress progressInfo, bool showStatusChanged)
		{
		}

		// Token: 0x170062C8 RID: 25288
		// (get) Token: 0x06029D20 RID: 171296 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170062C8")]
		public string areaId
		{
			[Token(Token = "0x6029D20")]
			[Address(RVA = "0x2577240", Offset = "0x2575E40", VA = "0x182577240")]
			get
			{
				return null;
			}
		}

		// Token: 0x06029D21 RID: 171297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029D21")]
		[Address(RVA = "0x2577010", Offset = "0x2575C10", VA = "0x182577010")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06029D22 RID: 171298 RVA: 0x000D6B30 File Offset: 0x000D4D30
		[Token(Token = "0x6029D22")]
		[Address(RVA = "0x2576EB0", Offset = "0x2575AB0", VA = "0x182576EB0")]
		public bool TryRegisterAreaGo()
		{
			return default(bool);
		}

		// Token: 0x06029D23 RID: 171299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029D23")]
		[Address(RVA = "0x25771E0", Offset = "0x2575DE0", VA = "0x1825771E0")]
		public Act42d0AreaButtonHolder()
		{
		}

		// Token: 0x0403BE40 RID: 245312
		[Token(Token = "0x403BE40")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _buttonContainer;

		// Token: 0x0403BE41 RID: 245313
		[Token(Token = "0x403BE41")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Act42d0AreaButton _btnPrefab;

		// Token: 0x0403BE42 RID: 245314
		[Token(Token = "0x403BE42")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _areaId;

		// Token: 0x0403BE43 RID: 245315
		[Token(Token = "0x403BE43")]
		[FieldOffset(Offset = "0x30")]
		private Act42d0AreaButton m_cachedBtn;

		// Token: 0x0403BE44 RID: 245316
		[Token(Token = "0x403BE44")]
		[FieldOffset(Offset = "0x38")]
		private bool m_isInited;

		// Token: 0x0403BE45 RID: 245317
		[Token(Token = "0x403BE45")]
		[FieldOffset(Offset = "0x40")]
		private Act42d0AreaViewModel m_viewModel;

		// Token: 0x0403BE46 RID: 245318
		[Token(Token = "0x403BE46")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403BE47 RID: 245319
		[Token(Token = "0x403BE47")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_areaId;

		// Token: 0x0403BE48 RID: 245320
		[Token(Token = "0x403BE48")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403BE49 RID: 245321
		[Token(Token = "0x403BE49")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_TryRegisterAreaGo;

		// Token: 0x0403BE4A RID: 245322
		[Token(Token = "0x403BE4A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
