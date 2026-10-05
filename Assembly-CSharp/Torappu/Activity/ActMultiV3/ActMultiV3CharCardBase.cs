using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006EF1 RID: 28401
	[Token(Token = "0x2006EF1")]
	public abstract class ActMultiV3CharCardBase : MonoBehaviour, IHotfixable
	{
		// Token: 0x17005F47 RID: 24391
		// (get) Token: 0x060285B6 RID: 165302 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005F47")]
		public UIColorGraphic colorGraphic
		{
			[Token(Token = "0x60285B6")]
			[Address(RVA = "0x23A8D80", Offset = "0x23A7980", VA = "0x1823A8D80")]
			get
			{
				return null;
			}
		}

		// Token: 0x060285B7 RID: 165303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60285B7")]
		[Address(RVA = "0x23A87F0", Offset = "0x23A73F0", VA = "0x1823A87F0")]
		public void RenderView(ActMultiV3CharCardBase.Param param)
		{
		}

		// Token: 0x060285B8 RID: 165304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60285B8")]
		[Address(RVA = "0x23A8790", Offset = "0x23A7390", VA = "0x1823A8790", Slot = "4")]
		protected virtual void OnRenderView()
		{
		}

		// Token: 0x060285B9 RID: 165305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60285B9")]
		[Address(RVA = "0x23A8980", Offset = "0x23A7580", VA = "0x1823A8980")]
		private void _Render(ActMultiV3CharCardBase.Param param)
		{
		}

		// Token: 0x060285BA RID: 165306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60285BA")]
		[Address(RVA = "0x23A83D0", Offset = "0x23A6FD0", VA = "0x1823A83D0")]
		public static void FillParam(ActMultiV3CharCardBase.Param baseParam, ActMultiV3IdentityType identityType, ActMultiV3CharViewModel cardViewModel, bool showSkillAndEquip)
		{
		}

		// Token: 0x060285BB RID: 165307 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60285BB")]
		[Address(RVA = "0x23A88A0", Offset = "0x23A74A0", VA = "0x1823A88A0")]
		private static PlayerCharSkill _FindSkill(ListDict<string, PlayerCharSkill> skills, string skillId)
		{
			return null;
		}

		// Token: 0x060285BC RID: 165308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60285BC")]
		[Address(RVA = "0x23A8D20", Offset = "0x23A7920", VA = "0x1823A8D20")]
		protected ActMultiV3CharCardBase()
		{
		}

		// Token: 0x040395D9 RID: 234969
		[Token(Token = "0x40395D9")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _emptyPartGO;

		// Token: 0x040395DA RID: 234970
		[Token(Token = "0x40395DA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _normalPartGO;

		// Token: 0x040395DB RID: 234971
		[Token(Token = "0x40395DB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIAtlasImage _imgCharPortrait;

		// Token: 0x040395DC RID: 234972
		[Token(Token = "0x40395DC")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textLv;

		// Token: 0x040395DD RID: 234973
		[Token(Token = "0x40395DD")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIAtlasImage _imgBanner;

		// Token: 0x040395DE RID: 234974
		[Token(Token = "0x40395DE")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private ActMultiV3CharCardBase.IdentityColorConfig[] _colorConfigs;

		// Token: 0x040395DF RID: 234975
		[Token(Token = "0x40395DF")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _potentialGO;

		// Token: 0x040395E0 RID: 234976
		[Token(Token = "0x40395E0")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Image _iconPotential;

		// Token: 0x040395E1 RID: 234977
		[Token(Token = "0x40395E1")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Image _imgElite;

		// Token: 0x040395E2 RID: 234978
		[Token(Token = "0x40395E2")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Image _imgProfession;

		// Token: 0x040395E3 RID: 234979
		[Token(Token = "0x40395E3")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private UIColorGraphic _colorGraphic;

		// Token: 0x040395E4 RID: 234980
		[Token(Token = "0x40395E4")]
		[FieldOffset(Offset = "0x70")]
		protected ActMultiV3CharCardBase.Param m_param;

		// Token: 0x040395E5 RID: 234981
		[Token(Token = "0x40395E5")]
		[FieldOffset(Offset = "0x78")]
		private string m_cachePortraitId;

		// Token: 0x040395E6 RID: 234982
		[Token(Token = "0x40395E6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_colorGraphic;

		// Token: 0x040395E7 RID: 234983
		[Token(Token = "0x40395E7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RenderView;

		// Token: 0x040395E8 RID: 234984
		[Token(Token = "0x40395E8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnRenderView;

		// Token: 0x040395E9 RID: 234985
		[Token(Token = "0x40395E9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__Render;

		// Token: 0x040395EA RID: 234986
		[Token(Token = "0x40395EA")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_FillParam;

		// Token: 0x040395EB RID: 234987
		[Token(Token = "0x40395EB")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__FindSkill;

		// Token: 0x040395EC RID: 234988
		[Token(Token = "0x40395EC")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006EF2 RID: 28402
		[Token(Token = "0x2006EF2")]
		[Serializable]
		public class IdentityColorConfig
		{
			// Token: 0x060285BD RID: 165309 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60285BD")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public IdentityColorConfig()
			{
			}

			// Token: 0x040395ED RID: 234989
			[Token(Token = "0x40395ED")]
			[FieldOffset(Offset = "0x10")]
			public ActMultiV3IdentityType idType;

			// Token: 0x040395EE RID: 234990
			[Token(Token = "0x40395EE")]
			[FieldOffset(Offset = "0x14")]
			public Color color;
		}

		// Token: 0x02006EF3 RID: 28403
		[Token(Token = "0x2006EF3")]
		public class Param
		{
			// Token: 0x060285BE RID: 165310 RVA: 0x000D1A60 File Offset: 0x000CFC60
			[Token(Token = "0x60285BE")]
			[Address(RVA = "0x1F00EC0", Offset = "0x1EFFAC0", VA = "0x181F00EC0")]
			public bool IsEmpty()
			{
				return default(bool);
			}

			// Token: 0x060285BF RID: 165311 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60285BF")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Param()
			{
			}

			// Token: 0x040395EF RID: 234991
			[Token(Token = "0x40395EF")]
			[FieldOffset(Offset = "0x10")]
			public ActMultiV3IdentityType idType;

			// Token: 0x040395F0 RID: 234992
			[Token(Token = "0x40395F0")]
			[FieldOffset(Offset = "0x18")]
			public ICharacterCardViewModel charBaseModel;

			// Token: 0x040395F1 RID: 234993
			[Token(Token = "0x40395F1")]
			[FieldOffset(Offset = "0x20")]
			public string portraitId;

			// Token: 0x040395F2 RID: 234994
			[Token(Token = "0x40395F2")]
			[FieldOffset(Offset = "0x28")]
			public bool showIconPriClass;

			// Token: 0x040395F3 RID: 234995
			[Token(Token = "0x40395F3")]
			[FieldOffset(Offset = "0x29")]
			public bool showSkillAndEquip;

			// Token: 0x040395F4 RID: 234996
			[Token(Token = "0x40395F4")]
			[FieldOffset(Offset = "0x30")]
			public ActMultiV3CharCardBase.Param.SkillInfo skillInfo;

			// Token: 0x040395F5 RID: 234997
			[Token(Token = "0x40395F5")]
			[FieldOffset(Offset = "0x38")]
			public ActMultiV3CharCardBase.Param.EquipInfo equipInfo;

			// Token: 0x02006EF4 RID: 28404
			[Token(Token = "0x2006EF4")]
			public class SkillInfo
			{
				// Token: 0x060285C0 RID: 165312 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60285C0")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public SkillInfo()
				{
				}

				// Token: 0x040395F6 RID: 234998
				[Token(Token = "0x40395F6")]
				[FieldOffset(Offset = "0x10")]
				public string skillId;

				// Token: 0x040395F7 RID: 234999
				[Token(Token = "0x40395F7")]
				[FieldOffset(Offset = "0x18")]
				public int mainLv;

				// Token: 0x040395F8 RID: 235000
				[Token(Token = "0x40395F8")]
				[FieldOffset(Offset = "0x1C")]
				public int specLv;
			}

			// Token: 0x02006EF5 RID: 28405
			[Token(Token = "0x2006EF5")]
			public class EquipInfo
			{
				// Token: 0x060285C1 RID: 165313 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x60285C1")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public EquipInfo()
				{
				}

				// Token: 0x040395F9 RID: 235001
				[Token(Token = "0x40395F9")]
				[FieldOffset(Offset = "0x10")]
				public string equipId;

				// Token: 0x040395FA RID: 235002
				[Token(Token = "0x40395FA")]
				[FieldOffset(Offset = "0x18")]
				public int level;
			}
		}
	}
}
