using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.Particle;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI
{
	// Token: 0x0200015B RID: 347
	[Token(Token = "0x200015B")]
	[RequireComponent(typeof(CanvasRenderer))]
	[ExecuteInEditMode]
	[RequireComponent(typeof(RectTransform))]
	public class UIParticle : MaskableGraphic
	{
		// Token: 0x170000AE RID: 174
		// (get) Token: 0x06000812 RID: 2066 RVA: 0x00006CD4 File Offset: 0x00004ED4
		// (set) Token: 0x06000813 RID: 2067 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x170000AE")]
		public override bool raycastTarget
		{
			[Token(Token = "0x6000812")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "24")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000813")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "25")]
			set
			{
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x06000814 RID: 2068 RVA: 0x00006CEC File Offset: 0x00004EEC
		// (set) Token: 0x06000815 RID: 2069 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x170000AF")]
		public UIParticle.MeshSharing meshSharing
		{
			[Token(Token = "0x6000814")]
			[Address(RVA = "0x5080A70", Offset = "0x507F670", VA = "0x185080A70")]
			get
			{
				return UIParticle.MeshSharing.None;
			}
			[Token(Token = "0x6000815")]
			[Address(RVA = "0x5547740", Offset = "0x5546340", VA = "0x185547740")]
			set
			{
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x06000816 RID: 2070 RVA: 0x00006D04 File Offset: 0x00004F04
		[Token(Token = "0x170000B0")]
		public long groupId
		{
			[Token(Token = "0x6000816")]
			[Address(RVA = "0x4D6C800", Offset = "0x4D6B400", VA = "0x184D6C800")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x06000817 RID: 2071 RVA: 0x00006D1C File Offset: 0x00004F1C
		[Token(Token = "0x170000B1")]
		internal bool useMeshSharing
		{
			[Token(Token = "0x6000817")]
			[Address(RVA = "0x55476F0", Offset = "0x55462F0", VA = "0x1855476F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x06000818 RID: 2072 RVA: 0x00006D34 File Offset: 0x00004F34
		[Token(Token = "0x170000B2")]
		internal bool isPrimary
		{
			[Token(Token = "0x6000818")]
			[Address(RVA = "0x55475D0", Offset = "0x55461D0", VA = "0x1855475D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x06000819 RID: 2073 RVA: 0x00006D4C File Offset: 0x00004F4C
		[Token(Token = "0x170000B3")]
		internal bool canSimulate
		{
			[Token(Token = "0x6000819")]
			[Address(RVA = "0x5547590", Offset = "0x5546190", VA = "0x185547590")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x0600081A RID: 2074 RVA: 0x00006D64 File Offset: 0x00004F64
		[Token(Token = "0x170000B4")]
		internal bool canRender
		{
			[Token(Token = "0x600081A")]
			[Address(RVA = "0x5547570", Offset = "0x5546170", VA = "0x185547570")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x0600081B RID: 2075 RVA: 0x00006D7C File Offset: 0x00004F7C
		// (set) Token: 0x0600081C RID: 2076 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x170000B5")]
		public float scale
		{
			[Token(Token = "0x600081B")]
			[Address(RVA = "0x55476E0", Offset = "0x55462E0", VA = "0x1855476E0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600081C")]
			[Address(RVA = "0x5547770", Offset = "0x5546370", VA = "0x185547770")]
			set
			{
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x0600081D RID: 2077 RVA: 0x00006D94 File Offset: 0x00004F94
		// (set) Token: 0x0600081E RID: 2078 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x170000B6")]
		public Vector3 scale3D
		{
			[Token(Token = "0x600081D")]
			[Address(RVA = "0x55476C0", Offset = "0x55462C0", VA = "0x1855476C0")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600081E")]
			[Address(RVA = "0x5547750", Offset = "0x5546350", VA = "0x185547750")]
			set
			{
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x0600081F RID: 2079 RVA: 0x00006DAC File Offset: 0x00004FAC
		[Token(Token = "0x170000B7")]
		public Vector3 scale3DForCalc
		{
			[Token(Token = "0x600081F")]
			[Address(RVA = "0x55476C0", Offset = "0x55462C0", VA = "0x1855476C0")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x06000820 RID: 2080 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000B8")]
		public List<ParticleSystem> particles
		{
			[Token(Token = "0x6000820")]
			[Address(RVA = "0x4D6C490", Offset = "0x4D6B090", VA = "0x184D6C490")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x06000821 RID: 2081 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000B9")]
		public IEnumerable<Material> materials
		{
			[Token(Token = "0x6000821")]
			[Address(RVA = "0x55475F0", Offset = "0x55461F0", VA = "0x1855475F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x06000822 RID: 2082 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000BA")]
		public override Material materialForRendering
		{
			[Token(Token = "0x6000822")]
			[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "36")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x06000823 RID: 2083 RVA: 0x00006DC4 File Offset: 0x00004FC4
		// (set) Token: 0x06000824 RID: 2084 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x170000BB")]
		public bool isPaused
		{
			[Token(Token = "0x6000823")]
			[Address(RVA = "0x4E7EAB0", Offset = "0x4E7D6B0", VA = "0x184E7EAB0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000824")]
			[Address(RVA = "0x5547730", Offset = "0x5546330", VA = "0x185547730")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x06000825 RID: 2085 RVA: 0x00006DDC File Offset: 0x00004FDC
		[Token(Token = "0x170000BC")]
		public Vector3 parentScale
		{
			[Token(Token = "0x6000825")]
			[Address(RVA = "0x5547670", Offset = "0x5546270", VA = "0x185547670")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x06000826 RID: 2086 RVA: 0x00006DF4 File Offset: 0x00004FF4
		// (set) Token: 0x06000827 RID: 2087 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x170000BD")]
		public Vector3 canvasScale
		{
			[Token(Token = "0x6000826")]
			[Address(RVA = "0x55475B0", Offset = "0x55461B0", VA = "0x1855475B0")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000827")]
			[Address(RVA = "0x5547710", Offset = "0x5546310", VA = "0x185547710")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000828 RID: 2088 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000828")]
		[Address(RVA = "0x5545A70", Offset = "0x5544670", VA = "0x185545A70", Slot = "5")]
		protected override void OnEnable()
		{
		}

		// Token: 0x06000829 RID: 2089 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000829")]
		[Address(RVA = "0x5545820", Offset = "0x5544420", VA = "0x185545820", Slot = "7")]
		protected override void OnDisable()
		{
		}

		// Token: 0x0600082A RID: 2090 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600082A")]
		[Address(RVA = "0x5545D00", Offset = "0x5544900", VA = "0x185545D00")]
		public void Play()
		{
		}

		// Token: 0x0600082B RID: 2091 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600082B")]
		[Address(RVA = "0x5545BD0", Offset = "0x55447D0", VA = "0x185545BD0")]
		public void Pause()
		{
		}

		// Token: 0x0600082C RID: 2092 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600082C")]
		[Address(RVA = "0x55463B0", Offset = "0x5544FB0", VA = "0x1855463B0")]
		public void Resume()
		{
		}

		// Token: 0x0600082D RID: 2093 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600082D")]
		[Address(RVA = "0x55465E0", Offset = "0x55451E0", VA = "0x1855465E0")]
		public void Stop()
		{
		}

		// Token: 0x0600082E RID: 2094 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600082E")]
		[Address(RVA = "0x55463C0", Offset = "0x5544FC0", VA = "0x1855463C0")]
		public void StartEmission()
		{
		}

		// Token: 0x0600082F RID: 2095 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600082F")]
		[Address(RVA = "0x55464D0", Offset = "0x55450D0", VA = "0x1855464D0")]
		public void StopEmission()
		{
		}

		// Token: 0x06000830 RID: 2096 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000830")]
		[Address(RVA = "0x5545560", Offset = "0x5544160", VA = "0x185545560")]
		public void Clear()
		{
		}

		// Token: 0x06000831 RID: 2097 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000831")]
		[Address(RVA = "0x55463A0", Offset = "0x5544FA0", VA = "0x1855463A0")]
		public void RefreshParticles()
		{
		}

		// Token: 0x06000832 RID: 2098 RVA: 0x00006E0C File Offset: 0x0000500C
		[Token(Token = "0x6000832")]
		[Address(RVA = "0x5545800", Offset = "0x5544400", VA = "0x185545800")]
		public UIParticle.ParticleVars GetParticleVars()
		{
			return default(UIParticle.ParticleVars);
		}

		// Token: 0x06000833 RID: 2099 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000833")]
		[Address(RVA = "0x5546710", Offset = "0x5545310", VA = "0x185546710")]
		public void UpdateParticleVars(UIParticle.ParticleVars vars)
		{
		}

		// Token: 0x06000834 RID: 2100 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000834")]
		[Address(RVA = "0x5545E30", Offset = "0x5544A30", VA = "0x185545E30")]
		public void RefreshParticles(List<ParticleSystem> particles)
		{
		}

		// Token: 0x06000835 RID: 2101 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000835")]
		[Address(RVA = "0x5546860", Offset = "0x5545460", VA = "0x185546860")]
		internal void UpdateRenderers()
		{
		}

		// Token: 0x06000836 RID: 2102 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000836")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "42")]
		protected override void UpdateMaterial()
		{
		}

		// Token: 0x06000837 RID: 2103 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000837")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "43")]
		protected override void UpdateGeometry()
		{
		}

		// Token: 0x06000838 RID: 2104 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000838")]
		[Address(RVA = "0x55472D0", Offset = "0x5545ED0", VA = "0x1855472D0")]
		private void _UpdateRendererMaterial()
		{
		}

		// Token: 0x06000839 RID: 2105 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000839")]
		[Address(RVA = "0x5545690", Offset = "0x5544290", VA = "0x185545690")]
		public UIParticleRenderer GetOrCreateRenderer(int index)
		{
			return null;
		}

		// Token: 0x0600083A RID: 2106 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600083A")]
		[Address(RVA = "0x55470C0", Offset = "0x5545CC0", VA = "0x1855470C0")]
		private UIParticle.ParticleContext _GetOrCreateContext(ParticleSystem ps)
		{
			return null;
		}

		// Token: 0x0600083B RID: 2107 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600083B")]
		[Address(RVA = "0x55469F0", Offset = "0x55455F0", VA = "0x1855469F0")]
		private Camera _GetBakeCamera()
		{
			return null;
		}

		// Token: 0x0600083C RID: 2108 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600083C")]
		[Address(RVA = "0x55473D0", Offset = "0x5545FD0", VA = "0x1855473D0")]
		public UIParticle()
		{
		}

		// Token: 0x0400076F RID: 1903
		[Token(Token = "0x400076F")]
		[FieldOffset(Offset = "0xE8")]
		[Tooltip("Particles would draw in the order of this list.")]
		[SerializeField]
		private List<ParticleSystem> _particles;

		// Token: 0x04000770 RID: 1904
		[Token(Token = "0x4000770")]
		[FieldOffset(Offset = "0xF0")]
		[Tooltip("Mesh sharing.\nNone: disable mesh sharing.\nAuto: automatically select Primary/Replica.\nPrimary: provides particle simulation results to the same group.\nPrimary Simulator: Primary, but do not render the particle (simulation only).\nReplica: render simulation results provided by the primary.")]
		[SerializeField]
		private UIParticle.MeshSharing _meshSharing;

		// Token: 0x04000771 RID: 1905
		[Token(Token = "0x4000771")]
		[FieldOffset(Offset = "0xF8")]
		[Tooltip("Mesh sharing group ID.\nIf non-zero is specified, particle simulation results are shared within the group.")]
		[SerializeField]
		private long _groupId;

		// Token: 0x04000772 RID: 1906
		[Token(Token = "0x4000772")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private Vector3 _scale3D;

		// Token: 0x04000773 RID: 1907
		[Token(Token = "0x4000773")]
		[FieldOffset(Offset = "0x110")]
		private readonly List<UIParticleRenderer> m_renderers;

		// Token: 0x04000774 RID: 1908
		[Token(Token = "0x4000774")]
		[FieldOffset(Offset = "0x118")]
		private Camera m_orthoCamera;

		// Token: 0x04000775 RID: 1909
		[Token(Token = "0x4000775")]
		[FieldOffset(Offset = "0x120")]
		private UIParticle.ParticleVars m_psVars;

		// Token: 0x04000776 RID: 1910
		[Token(Token = "0x4000776")]
		[FieldOffset(Offset = "0x130")]
		private readonly Dictionary<int, UIParticle.ParticleContext> m_psContexts;

		// Token: 0x0200015C RID: 348
		[Token(Token = "0x200015C")]
		public enum MeshSharing
		{
			// Token: 0x0400077A RID: 1914
			[Token(Token = "0x400077A")]
			None,
			// Token: 0x0400077B RID: 1915
			[Token(Token = "0x400077B")]
			Auto,
			// Token: 0x0400077C RID: 1916
			[Token(Token = "0x400077C")]
			Primary,
			// Token: 0x0400077D RID: 1917
			[Token(Token = "0x400077D")]
			PrimarySimulator,
			// Token: 0x0400077E RID: 1918
			[Token(Token = "0x400077E")]
			Replica
		}

		// Token: 0x0200015D RID: 349
		[Token(Token = "0x200015D")]
		public class ParticleContext
		{
			// Token: 0x170000BE RID: 190
			// (get) Token: 0x0600083D RID: 2109 RVA: 0x00002066 File Offset: 0x00000266
			// (set) Token: 0x0600083E RID: 2110 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x170000BE")]
			public ParticleSystem system
			{
				[Token(Token = "0x600083D")]
				[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x600083E")]
				[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170000BF RID: 191
			// (get) Token: 0x0600083F RID: 2111 RVA: 0x00002066 File Offset: 0x00000266
			// (set) Token: 0x06000840 RID: 2112 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x170000BF")]
			public ParticleSystemRenderer renderer
			{
				[Token(Token = "0x600083F")]
				[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6000840")]
				[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170000C0 RID: 192
			// (get) Token: 0x06000841 RID: 2113 RVA: 0x00002066 File Offset: 0x00000266
			// (set) Token: 0x06000842 RID: 2114 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x170000C0")]
			public Material mainMaterial
			{
				[Token(Token = "0x6000841")]
				[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6000842")]
				[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170000C1 RID: 193
			// (get) Token: 0x06000843 RID: 2115 RVA: 0x00002066 File Offset: 0x00000266
			// (set) Token: 0x06000844 RID: 2116 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x170000C1")]
			public Material trailMaterial
			{
				[Token(Token = "0x6000843")]
				[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6000844")]
				[Address(RVA = "0x4E6EB0", Offset = "0x4E5AB0", VA = "0x1804E6EB0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170000C2 RID: 194
			// (get) Token: 0x06000845 RID: 2117 RVA: 0x00002066 File Offset: 0x00000266
			// (set) Token: 0x06000846 RID: 2118 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x170000C2")]
			public ParticleGeometryUtils.BakeCache bakeCache
			{
				[Token(Token = "0x6000845")]
				[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6000846")]
				[Address(RVA = "0x4EAC30", Offset = "0x4E9830", VA = "0x1804EAC30")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170000C3 RID: 195
			// (get) Token: 0x06000847 RID: 2119 RVA: 0x00006E24 File Offset: 0x00005024
			// (set) Token: 0x06000848 RID: 2120 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x170000C3")]
			public Vector3 particleScale
			{
				[Token(Token = "0x6000847")]
				[Address(RVA = "0x32FB1B0", Offset = "0x32F9DB0", VA = "0x1832FB1B0")]
				[CompilerGenerated]
				get
				{
					return default(Vector3);
				}
				[Token(Token = "0x6000848")]
				[Address(RVA = "0x5531CB0", Offset = "0x55308B0", VA = "0x185531CB0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x06000849 RID: 2121 RVA: 0x00006E3C File Offset: 0x0000503C
			[Token(Token = "0x6000849")]
			[Address(RVA = "0x5531C20", Offset = "0x5530820", VA = "0x185531C20")]
			public bool IsValidForRenderer()
			{
				return default(bool);
			}

			// Token: 0x0600084A RID: 2122 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x600084A")]
			[Address(RVA = "0x5531B90", Offset = "0x5530790", VA = "0x185531B90")]
			public void DisableRenderer()
			{
			}

			// Token: 0x0600084B RID: 2123 RVA: 0x00006E54 File Offset: 0x00005054
			[Token(Token = "0x600084B")]
			[Address(RVA = "0x5531D80", Offset = "0x5530980", VA = "0x185531D80")]
			public bool ShouldRenderTrail()
			{
				return default(bool);
			}

			// Token: 0x0600084C RID: 2124 RVA: 0x00006E6C File Offset: 0x0000506C
			[Token(Token = "0x600084C")]
			[Address(RVA = "0x5531CC0", Offset = "0x55308C0", VA = "0x185531CC0")]
			public bool ShouldRenderMain()
			{
				return default(bool);
			}

			// Token: 0x0600084D RID: 2125 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x600084D")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			private ParticleContext()
			{
			}

			// Token: 0x0600084E RID: 2126 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x600084E")]
			[Address(RVA = "0x5531A40", Offset = "0x5530640", VA = "0x185531A40")]
			public static UIParticle.ParticleContext Create(ParticleSystem ps)
			{
				return null;
			}

			// Token: 0x0600084F RID: 2127 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x600084F")]
			[Address(RVA = "0x5531CB0", Offset = "0x55308B0", VA = "0x185531CB0")]
			public void SetVars(UIParticle.ParticleVars vars)
			{
			}
		}

		// Token: 0x0200015E RID: 350
		[Token(Token = "0x200015E")]
		public struct ParticleVars
		{
			// Token: 0x04000785 RID: 1925
			[Token(Token = "0x4000785")]
			[FieldOffset(Offset = "0x0")]
			public static readonly UIParticle.ParticleVars DEFAULT;

			// Token: 0x04000786 RID: 1926
			[Token(Token = "0x4000786")]
			[FieldOffset(Offset = "0x0")]
			public Vector3 particleScale;
		}
	}
}
