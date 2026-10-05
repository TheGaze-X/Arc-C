using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.EventSystems
{
	// Token: 0x020000D6 RID: 214
	[Token(Token = "0x20000D6")]
	public abstract class BaseRaycaster : UIBehaviour
	{
		// Token: 0x060007B0 RID: 1968
		[Token(Token = "0x60007B0")]
		public abstract void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList);

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x060007B1 RID: 1969
		[Token(Token = "0x17000208")]
		public abstract Camera eventCamera { [Token(Token = "0x60007B1")] get; }

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x060007B2 RID: 1970 RVA: 0x00005070 File Offset: 0x00003270
		[Token(Token = "0x17000209")]
		[Obsolete("Please use sortOrderPriority and renderOrderPriority", false)]
		public virtual int priority
		{
			[Token(Token = "0x60007B2")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "19")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x060007B3 RID: 1971 RVA: 0x00005088 File Offset: 0x00003288
		[Token(Token = "0x1700020A")]
		public virtual int sortOrderPriority
		{
			[Token(Token = "0x60007B3")]
			[Address(RVA = "0x5B84C70", Offset = "0x5B83870", VA = "0x185B84C70", Slot = "20")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x060007B4 RID: 1972 RVA: 0x000050A0 File Offset: 0x000032A0
		[Token(Token = "0x1700020B")]
		public virtual int renderOrderPriority
		{
			[Token(Token = "0x60007B4")]
			[Address(RVA = "0x5B84C70", Offset = "0x5B83870", VA = "0x185B84C70", Slot = "21")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x060007B5 RID: 1973 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700020C")]
		public BaseRaycaster rootRaycaster
		{
			[Token(Token = "0x60007B5")]
			[Address(RVA = "0x5B84C80", Offset = "0x5B83880", VA = "0x185B84C80")]
			get
			{
				return null;
			}
		}

		// Token: 0x060007B6 RID: 1974 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007B6")]
		[Address(RVA = "0x5B84840", Offset = "0x5B83440", VA = "0x185B84840", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060007B7 RID: 1975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007B7")]
		[Address(RVA = "0x5B84740", Offset = "0x5B83340", VA = "0x185B84740", Slot = "5")]
		protected override void OnEnable()
		{
		}

		// Token: 0x060007B8 RID: 1976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007B8")]
		[Address(RVA = "0x5B84640", Offset = "0x5B83240", VA = "0x185B84640", Slot = "7")]
		protected override void OnDisable()
		{
		}

		// Token: 0x060007B9 RID: 1977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007B9")]
		[Address(RVA = "0x3698D80", Offset = "0x3697980", VA = "0x183698D80", Slot = "15")]
		protected override void OnCanvasHierarchyChanged()
		{
		}

		// Token: 0x060007BA RID: 1978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007BA")]
		[Address(RVA = "0x3698D80", Offset = "0x3697980", VA = "0x183698D80", Slot = "12")]
		protected override void OnTransformParentChanged()
		{
		}

		// Token: 0x060007BB RID: 1979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007BB")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		protected BaseRaycaster()
		{
		}

		// Token: 0x0400039C RID: 924
		[Token(Token = "0x400039C")]
		[FieldOffset(Offset = "0x18")]
		private BaseRaycaster m_RootRaycaster;
	}
}
