using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x02000085 RID: 133
	[Token(Token = "0x2000085")]
	[ExecuteAlways]
	[AddComponentMenu("Rendering/Post-process Volume", 1001)]
	public sealed class PostProcessVolume : MonoBehaviour
	{
		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060001D3 RID: 467 RVA: 0x000020AE File Offset: 0x000002AE
		// (set) Token: 0x060001D4 RID: 468 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x17000028")]
		public PostProcessProfile profile
		{
			[Token(Token = "0x60001D3")]
			[Address(RVA = "0x5844DF0", Offset = "0x58439F0", VA = "0x185844DF0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001D4")]
			[Address(RVA = "0x54AEC0", Offset = "0x549AC0", VA = "0x18054AEC0")]
			set
			{
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060001D5 RID: 469 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x17000029")]
		internal PostProcessProfile profileRef
		{
			[Token(Token = "0x60001D5")]
			[Address(RVA = "0x5844D70", Offset = "0x5843970", VA = "0x185844D70")]
			get
			{
				return null;
			}
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x00002B1C File Offset: 0x00000D1C
		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x5844340", Offset = "0x5842F40", VA = "0x185844340")]
		public bool HasInstantiatedProfile()
		{
			return default(bool);
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x5844BE0", Offset = "0x58437E0", VA = "0x185844BE0")]
		private void OnEnable()
		{
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x5844390", Offset = "0x5842F90", VA = "0x185844390")]
		private void OnDisable()
		{
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x5844CC0", Offset = "0x58438C0", VA = "0x185844CC0")]
		private void Update()
		{
		}

		// Token: 0x060001DA RID: 474 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x58443F0", Offset = "0x5842FF0", VA = "0x1858443F0")]
		private void OnDrawGizmos()
		{
		}

		// Token: 0x060001DB RID: 475 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x2879610", Offset = "0x2878210", VA = "0x182879610")]
		public PostProcessVolume()
		{
		}

		// Token: 0x04000294 RID: 660
		[Token(Token = "0x4000294")]
		[FieldOffset(Offset = "0x18")]
		public PostProcessProfile sharedProfile;

		// Token: 0x04000295 RID: 661
		[Token(Token = "0x4000295")]
		[FieldOffset(Offset = "0x20")]
		[Tooltip("Check this box to mark this volume as global. This volume's Profile will be applied to the whole Scene.")]
		public bool isGlobal;

		// Token: 0x04000296 RID: 662
		[Token(Token = "0x4000296")]
		[FieldOffset(Offset = "0x24")]
		[PPMin(0f)]
		[Tooltip("The distance (from the attached Collider) to start blending from. A value of 0 means there will be no blending and the Volume overrides will be applied immediatly upon entry to the attached Collider.")]
		public float blendDistance;

		// Token: 0x04000297 RID: 663
		[Token(Token = "0x4000297")]
		[FieldOffset(Offset = "0x28")]
		[Range(0f, 1f)]
		[Tooltip("The total weight of this Volume in the Scene. A value of 0 signifies that it will have no effect, 1 signifies full effect.")]
		public float weight;

		// Token: 0x04000298 RID: 664
		[Token(Token = "0x4000298")]
		[FieldOffset(Offset = "0x2C")]
		[Tooltip("The volume priority in the stack. A higher value means higher priority. Negative values are supported.")]
		public float priority;

		// Token: 0x04000299 RID: 665
		[Token(Token = "0x4000299")]
		[FieldOffset(Offset = "0x30")]
		private int m_PreviousLayer;

		// Token: 0x0400029A RID: 666
		[Token(Token = "0x400029A")]
		[FieldOffset(Offset = "0x34")]
		private float m_PreviousPriority;

		// Token: 0x0400029B RID: 667
		[Token(Token = "0x400029B")]
		[FieldOffset(Offset = "0x38")]
		private List<Collider> m_TempColliders;

		// Token: 0x0400029C RID: 668
		[Token(Token = "0x400029C")]
		[FieldOffset(Offset = "0x40")]
		private PostProcessProfile m_InternalProfile;
	}
}
