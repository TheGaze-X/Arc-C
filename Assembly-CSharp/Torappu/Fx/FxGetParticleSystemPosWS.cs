using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Fx
{
	// Token: 0x02002033 RID: 8243
	[Token(Token = "0x2002033")]
	[RequireComponent(typeof(ParticleSystem))]
	[RequireComponent(typeof(ParticleSystemRenderer))]
	public class FxGetParticleSystemPosWS : MonoBehaviour, IHotfixable
	{
		// Token: 0x1700180A RID: 6154
		// (get) Token: 0x0600CB22 RID: 52002 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700180A")]
		private Material activeMaterial
		{
			[Token(Token = "0x600CB22")]
			[Address(RVA = "0x34C2530", Offset = "0x34C1130", VA = "0x1834C2530")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600CB23 RID: 52003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CB23")]
		[Address(RVA = "0x34C2120", Offset = "0x34C0D20", VA = "0x1834C2120")]
		private void Awake()
		{
		}

		// Token: 0x0600CB24 RID: 52004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CB24")]
		[Address(RVA = "0x34C22E0", Offset = "0x34C0EE0", VA = "0x1834C22E0")]
		private void Update()
		{
		}

		// Token: 0x0600CB25 RID: 52005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CB25")]
		[Address(RVA = "0x34C24B0", Offset = "0x34C10B0", VA = "0x1834C24B0")]
		public FxGetParticleSystemPosWS()
		{
		}

		// Token: 0x0400D515 RID: 54549
		[Token(Token = "0x400D515")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int PARTICLE_POSITION_WS_ID;

		// Token: 0x0400D516 RID: 54550
		[Token(Token = "0x400D516")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool _needUpdate;

		// Token: 0x0400D517 RID: 54551
		[Token(Token = "0x400D517")]
		[FieldOffset(Offset = "0x20")]
		private Material m_activeMaterial;

		// Token: 0x0400D518 RID: 54552
		[Token(Token = "0x400D518")]
		[FieldOffset(Offset = "0x28")]
		private ParticleSystemRenderer m_renderer;

		// Token: 0x0400D519 RID: 54553
		[Token(Token = "0x400D519")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_activeMaterial;

		// Token: 0x0400D51A RID: 54554
		[Token(Token = "0x400D51A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x0400D51B RID: 54555
		[Token(Token = "0x400D51B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x0400D51C RID: 54556
		[Token(Token = "0x400D51C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
