using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Rendering
{
	// Token: 0x0200204B RID: 8267
	[Token(Token = "0x200204B")]
	[ExecuteInEditMode]
	public class SceneEffectConfig : MonoBehaviour
	{
		// Token: 0x17001826 RID: 6182
		// (get) Token: 0x0600CBC0 RID: 52160 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600CBC1 RID: 52161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001826")]
		public SceneEffectProfile effectProfile
		{
			[Token(Token = "0x600CBC0")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
			[Token(Token = "0x600CBC1")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			set
			{
			}
		}

		// Token: 0x17001827 RID: 6183
		// (get) Token: 0x0600CBC2 RID: 52162 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001827")]
		private SceneEffectProfile profile
		{
			[Token(Token = "0x600CBC2")]
			[Address(RVA = "0x34CD240", Offset = "0x34CBE40", VA = "0x1834CD240")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001828 RID: 6184
		// (get) Token: 0x0600CBC3 RID: 52163 RVA: 0x00049A40 File Offset: 0x00047C40
		[Token(Token = "0x17001828")]
		private bool graphicsGradingEnabled
		{
			[Token(Token = "0x600CBC3")]
			[Address(RVA = "0x34CD1A0", Offset = "0x34CBDA0", VA = "0x1834CD1A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001829 RID: 6185
		// (get) Token: 0x0600CBC4 RID: 52164 RVA: 0x00049A58 File Offset: 0x00047C58
		[Token(Token = "0x17001829")]
		private bool shadowTintEnabled
		{
			[Token(Token = "0x600CBC4")]
			[Address(RVA = "0x34CD300", Offset = "0x34CBF00", VA = "0x1834CD300")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700182A RID: 6186
		// (get) Token: 0x0600CBC5 RID: 52165 RVA: 0x00049A70 File Offset: 0x00047C70
		[Token(Token = "0x1700182A")]
		private bool HeightFogEnabled
		{
			[Token(Token = "0x600CBC5")]
			[Address(RVA = "0x34CD100", Offset = "0x34CBD00", VA = "0x1834CD100")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700182B RID: 6187
		// (get) Token: 0x0600CBC6 RID: 52166 RVA: 0x00049A88 File Offset: 0x00047C88
		[Token(Token = "0x1700182B")]
		private bool DirFogEnabled
		{
			[Token(Token = "0x600CBC6")]
			[Address(RVA = "0x34CD040", Offset = "0x34CBC40", VA = "0x1834CD040")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700182C RID: 6188
		// (get) Token: 0x0600CBC7 RID: 52167 RVA: 0x00049AA0 File Offset: 0x00047CA0
		[Token(Token = "0x1700182C")]
		private bool ColorGradingEnabled
		{
			[Token(Token = "0x600CBC7")]
			[Address(RVA = "0x34CCF70", Offset = "0x34CBB70", VA = "0x1834CCF70")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600CBC8 RID: 52168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CBC8")]
		[Address(RVA = "0x34CBC80", Offset = "0x34CA880", VA = "0x1834CBC80")]
		private void Init()
		{
		}

		// Token: 0x0600CBC9 RID: 52169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CBC9")]
		[Address(RVA = "0x34CBC80", Offset = "0x34CA880", VA = "0x1834CBC80")]
		private void Awake()
		{
		}

		// Token: 0x0600CBCA RID: 52170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CBCA")]
		[Address(RVA = "0x34CC1C0", Offset = "0x34CADC0", VA = "0x1834CC1C0")]
		private void OnEnable()
		{
		}

		// Token: 0x0600CBCB RID: 52171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CBCB")]
		[Address(RVA = "0x34CC100", Offset = "0x34CAD00", VA = "0x1834CC100")]
		private void OnDisable()
		{
		}

		// Token: 0x0600CBCC RID: 52172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CBCC")]
		[Address(RVA = "0x34CC070", Offset = "0x34CAC70", VA = "0x1834CC070")]
		private void EnableShadowTint()
		{
		}

		// Token: 0x0600CBCD RID: 52173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CBCD")]
		[Address(RVA = "0x34CBE40", Offset = "0x34CAA40", VA = "0x1834CBE40")]
		private void DisableShadowTint()
		{
		}

		// Token: 0x0600CBCE RID: 52174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CBCE")]
		[Address(RVA = "0x34CC020", Offset = "0x34CAC20", VA = "0x1834CC020")]
		private void EnableHeightFog()
		{
		}

		// Token: 0x0600CBCF RID: 52175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CBCF")]
		[Address(RVA = "0x34CBE00", Offset = "0x34CAA00", VA = "0x1834CBE00")]
		private void DisableHeightFog()
		{
		}

		// Token: 0x0600CBD0 RID: 52176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CBD0")]
		[Address(RVA = "0x34CBFD0", Offset = "0x34CABD0", VA = "0x1834CBFD0")]
		private void EnableDirFog()
		{
		}

		// Token: 0x0600CBD1 RID: 52177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CBD1")]
		[Address(RVA = "0x34CBD70", Offset = "0x34CA970", VA = "0x1834CBD70")]
		private void DisableDirFog()
		{
		}

		// Token: 0x0600CBD2 RID: 52178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CBD2")]
		[Address(RVA = "0x34CBEA0", Offset = "0x34CAAA0", VA = "0x1834CBEA0")]
		private void EnableColorGrading()
		{
		}

		// Token: 0x0600CBD3 RID: 52179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CBD3")]
		[Address(RVA = "0x34CBD30", Offset = "0x34CA930", VA = "0x1834CBD30")]
		private void DisableColorGrading()
		{
		}

		// Token: 0x0600CBD4 RID: 52180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CBD4")]
		[Address(RVA = "0x34CBDC0", Offset = "0x34CA9C0", VA = "0x1834CBDC0")]
		private void DisableGraphicsGrading()
		{
		}

		// Token: 0x0600CBD5 RID: 52181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CBD5")]
		[Address(RVA = "0x34CCE40", Offset = "0x34CBA40", VA = "0x1834CCE40")]
		private void UpdateShadowTint()
		{
		}

		// Token: 0x0600CBD6 RID: 52182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CBD6")]
		[Address(RVA = "0x34CCC20", Offset = "0x34CB820", VA = "0x1834CCC20")]
		private void UpdateHeightFog()
		{
		}

		// Token: 0x0600CBD7 RID: 52183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CBD7")]
		[Address(RVA = "0x34CC920", Offset = "0x34CB520", VA = "0x1834CC920")]
		private void UpdateDirFog()
		{
		}

		// Token: 0x0600CBD8 RID: 52184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CBD8")]
		[Address(RVA = "0x34CC820", Offset = "0x34CB420", VA = "0x1834CC820")]
		private void UpdateColorGrading()
		{
		}

		// Token: 0x0600CBD9 RID: 52185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CBD9")]
		[Address(RVA = "0x34CC240", Offset = "0x34CAE40", VA = "0x1834CC240")]
		public void Refresh()
		{
		}

		// Token: 0x0600CBDA RID: 52186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CBDA")]
		[Address(RVA = "0x34CCEA0", Offset = "0x34CBAA0", VA = "0x1834CCEA0")]
		public SceneEffectConfig()
		{
		}

		// Token: 0x0400D629 RID: 54825
		[Token(Token = "0x400D629")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SceneEffectProfile _effectProfile;

		// Token: 0x0400D62A RID: 54826
		[Token(Token = "0x400D62A")]
		[FieldOffset(Offset = "0x20")]
		private Vector4 m_heightFogParam;

		// Token: 0x0400D62B RID: 54827
		[Token(Token = "0x400D62B")]
		[FieldOffset(Offset = "0x30")]
		private Vector4 m_heightFogNoiseST;

		// Token: 0x0400D62C RID: 54828
		[Token(Token = "0x400D62C")]
		[FieldOffset(Offset = "0x40")]
		private Vector4 m_colorgradingParam;

		// Token: 0x0400D62D RID: 54829
		[Token(Token = "0x400D62D")]
		[FieldOffset(Offset = "0x50")]
		private Vector4 m_dirFogParam;

		// Token: 0x0400D62E RID: 54830
		[Token(Token = "0x400D62E")]
		[FieldOffset(Offset = "0x60")]
		private Vector4 m_dirFogParam2;

		// Token: 0x0400D62F RID: 54831
		[Token(Token = "0x400D62F")]
		[FieldOffset(Offset = "0x70")]
		private SceneDirectionalFog m_dirFogConfig;

		// Token: 0x0400D630 RID: 54832
		[Token(Token = "0x400D630")]
		[FieldOffset(Offset = "0x78")]
		private SceneEffectProfile m_profile;
	}
}
