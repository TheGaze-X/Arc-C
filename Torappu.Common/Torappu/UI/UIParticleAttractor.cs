using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace Torappu.UI
{
	// Token: 0x02000161 RID: 353
	[Token(Token = "0x2000161")]
	[ExecuteInEditMode]
	public class UIParticleAttractor : MonoBehaviour
	{
		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x06000862 RID: 2146 RVA: 0x00006E9C File Offset: 0x0000509C
		// (set) Token: 0x06000863 RID: 2147 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x170000C6")]
		public float destinationRadius
		{
			[Token(Token = "0x6000862")]
			[Address(RVA = "0x621E40", Offset = "0x620A40", VA = "0x180621E40")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000863")]
			[Address(RVA = "0x5541540", Offset = "0x5540140", VA = "0x185541540")]
			set
			{
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x06000864 RID: 2148 RVA: 0x00006EB4 File Offset: 0x000050B4
		// (set) Token: 0x06000865 RID: 2149 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x170000C7")]
		public float delay
		{
			[Token(Token = "0x6000864")]
			[Address(RVA = "0x73B8E0", Offset = "0x73A4E0", VA = "0x18073B8E0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000865")]
			[Address(RVA = "0x73B910", Offset = "0x73A510", VA = "0x18073B910")]
			set
			{
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x06000866 RID: 2150 RVA: 0x00006ECC File Offset: 0x000050CC
		// (set) Token: 0x06000867 RID: 2151 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x170000C8")]
		public float maxSpeed
		{
			[Token(Token = "0x6000866")]
			[Address(RVA = "0x7E7500", Offset = "0x7E6100", VA = "0x1807E7500")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000867")]
			[Address(RVA = "0x7E7510", Offset = "0x7E6110", VA = "0x1807E7510")]
			set
			{
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x06000868 RID: 2152 RVA: 0x00006EE4 File Offset: 0x000050E4
		// (set) Token: 0x06000869 RID: 2153 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x170000C9")]
		public UIParticleAttractor.Movement movement
		{
			[Token(Token = "0x6000868")]
			[Address(RVA = "0x4FD4B0", Offset = "0x4FC0B0", VA = "0x1804FD4B0")]
			get
			{
				return UIParticleAttractor.Movement.Linear;
			}
			[Token(Token = "0x6000869")]
			[Address(RVA = "0x150B0E0", Offset = "0x1509CE0", VA = "0x18150B0E0")]
			set
			{
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x0600086A RID: 2154 RVA: 0x00006EFC File Offset: 0x000050FC
		// (set) Token: 0x0600086B RID: 2155 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x170000CA")]
		public UIParticleAttractor.UpdateMode updateMode
		{
			[Token(Token = "0x600086A")]
			[Address(RVA = "0xC91700", Offset = "0xC90300", VA = "0x180C91700")]
			get
			{
				return UIParticleAttractor.UpdateMode.Normal;
			}
			[Token(Token = "0x600086B")]
			[Address(RVA = "0xF82EE0", Offset = "0xF81AE0", VA = "0x180F82EE0")]
			set
			{
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x0600086C RID: 2156 RVA: 0x00002066 File Offset: 0x00000266
		// (set) Token: 0x0600086D RID: 2157 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x170000CB")]
		public UnityEvent onAttracted
		{
			[Token(Token = "0x600086C")]
			[Address(RVA = "0x4EA850", Offset = "0x4E9450", VA = "0x1804EA850")]
			get
			{
				return null;
			}
			[Token(Token = "0x600086D")]
			[Address(RVA = "0x4EA990", Offset = "0x4E9590", VA = "0x1804EA990")]
			set
			{
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x0600086E RID: 2158 RVA: 0x00002066 File Offset: 0x00000266
		// (set) Token: 0x0600086F RID: 2159 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x170000CC")]
		public ParticleSystem particleSystem
		{
			[Token(Token = "0x600086E")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
			[Token(Token = "0x600086F")]
			[Address(RVA = "0x5541570", Offset = "0x5540170", VA = "0x185541570")]
			set
			{
			}
		}

		// Token: 0x06000870 RID: 2160 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000870")]
		[Address(RVA = "0x5540AA0", Offset = "0x553F6A0", VA = "0x185540AA0")]
		private void OnEnable()
		{
		}

		// Token: 0x06000871 RID: 2161 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000871")]
		[Address(RVA = "0x55409C0", Offset = "0x553F5C0", VA = "0x1855409C0")]
		private void OnDisable()
		{
		}

		// Token: 0x06000872 RID: 2162 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000872")]
		[Address(RVA = "0x5540980", Offset = "0x553F580", VA = "0x185540980")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000873 RID: 2163 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000873")]
		[Address(RVA = "0x5540570", Offset = "0x553F170", VA = "0x185540570")]
		internal void Attract()
		{
		}

		// Token: 0x06000874 RID: 2164 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000874")]
		[Address(RVA = "0x5540D10", Offset = "0x553F910", VA = "0x185540D10")]
		private void _AttractParticles(ParticleSystem.Particle[] particles, int count)
		{
		}

		// Token: 0x06000875 RID: 2165 RVA: 0x00006F14 File Offset: 0x00005114
		[Token(Token = "0x6000875")]
		[Address(RVA = "0x55412C0", Offset = "0x553FEC0", VA = "0x1855412C0")]
		private Vector3 _GetDestinationPosition()
		{
			return default(Vector3);
		}

		// Token: 0x06000876 RID: 2166 RVA: 0x00006F2C File Offset: 0x0000512C
		[Token(Token = "0x6000876")]
		[Address(RVA = "0x55406A0", Offset = "0x553F2A0", VA = "0x1855406A0")]
		private Vector3 GetAttractedPosition(Vector3 current, Vector3 target, float duration, float time)
		{
			return default(Vector3);
		}

		// Token: 0x06000877 RID: 2167 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000877")]
		[Address(RVA = "0x5540B90", Offset = "0x553F790", VA = "0x185540B90")]
		private void _ApplyParticleSystem()
		{
		}

		// Token: 0x06000878 RID: 2168 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000878")]
		[Address(RVA = "0x5541520", Offset = "0x5540120", VA = "0x185541520")]
		public UIParticleAttractor()
		{
		}

		// Token: 0x04000794 RID: 1940
		[Token(Token = "0x4000794")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ParticleSystem _particleSystem;

		// Token: 0x04000795 RID: 1941
		[Token(Token = "0x4000795")]
		[FieldOffset(Offset = "0x20")]
		[Range(0.1f, 10f)]
		[SerializeField]
		private float _destinationRadius;

		// Token: 0x04000796 RID: 1942
		[Token(Token = "0x4000796")]
		[FieldOffset(Offset = "0x24")]
		[Range(0f, 0.95f)]
		[SerializeField]
		private float _delayRate;

		// Token: 0x04000797 RID: 1943
		[Token(Token = "0x4000797")]
		[FieldOffset(Offset = "0x28")]
		[Range(0.001f, 100f)]
		[SerializeField]
		private float _maxSpeed;

		// Token: 0x04000798 RID: 1944
		[Token(Token = "0x4000798")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private UIParticleAttractor.Movement _movement;

		// Token: 0x04000799 RID: 1945
		[Token(Token = "0x4000799")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIParticleAttractor.UpdateMode _updateMode;

		// Token: 0x0400079A RID: 1946
		[Token(Token = "0x400079A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UnityEvent _onAttracted;

		// Token: 0x0400079B RID: 1947
		[Token(Token = "0x400079B")]
		[FieldOffset(Offset = "0x40")]
		private UIParticle m_uiParticle;

		// Token: 0x02000162 RID: 354
		[Token(Token = "0x2000162")]
		public enum Movement
		{
			// Token: 0x0400079D RID: 1949
			[Token(Token = "0x400079D")]
			Linear,
			// Token: 0x0400079E RID: 1950
			[Token(Token = "0x400079E")]
			Smooth,
			// Token: 0x0400079F RID: 1951
			[Token(Token = "0x400079F")]
			Sphere
		}

		// Token: 0x02000163 RID: 355
		[Token(Token = "0x2000163")]
		public enum UpdateMode
		{
			// Token: 0x040007A1 RID: 1953
			[Token(Token = "0x40007A1")]
			Normal,
			// Token: 0x040007A2 RID: 1954
			[Token(Token = "0x40007A2")]
			UnscaledTime
		}
	}
}
