using System;
using Il2CppDummyDll;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	// Token: 0x02000081 RID: 129
	[Token(Token = "0x2000081")]
	[ExecuteAlways]
	public abstract class BaseMeshEffect : UIBehaviour, IMeshModifier
	{
		// Token: 0x1700016C RID: 364
		// (get) Token: 0x0600056B RID: 1387 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700016C")]
		protected Graphic graphic
		{
			[Token(Token = "0x600056B")]
			[Address(RVA = "0x5B845A0", Offset = "0x5B831A0", VA = "0x185B845A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600056C RID: 1388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600056C")]
		[Address(RVA = "0x5B844F0", Offset = "0x5B830F0", VA = "0x185B844F0", Slot = "5")]
		protected override void OnEnable()
		{
		}

		// Token: 0x0600056D RID: 1389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600056D")]
		[Address(RVA = "0x5B84440", Offset = "0x5B83040", VA = "0x185B84440", Slot = "7")]
		protected override void OnDisable()
		{
		}

		// Token: 0x0600056E RID: 1390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600056E")]
		[Address(RVA = "0x5B84390", Offset = "0x5B82F90", VA = "0x185B84390", Slot = "13")]
		protected override void OnDidApplyAnimationProperties()
		{
		}

		// Token: 0x0600056F RID: 1391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600056F")]
		[Address(RVA = "0x5B84270", Offset = "0x5B82E70", VA = "0x185B84270", Slot = "19")]
		public virtual void ModifyMesh(Mesh mesh)
		{
		}

		// Token: 0x06000570 RID: 1392
		[Token(Token = "0x6000570")]
		public abstract void ModifyMesh(VertexHelper vh);

		// Token: 0x06000571 RID: 1393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000571")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		protected BaseMeshEffect()
		{
		}

		// Token: 0x0400028B RID: 651
		[Token(Token = "0x400028B")]
		[FieldOffset(Offset = "0x18")]
		[NonSerialized]
		private Graphic m_Graphic;
	}
}
