using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005260 RID: 21088
	[Token(Token = "0x2005260")]
	public class RoguelikeDungeonNodeView : MonoBehaviour, IRoguelikeDungeonNodeView, IHotfixable
	{
		// Token: 0x170048B2 RID: 18610
		// (get) Token: 0x0601F191 RID: 127377 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170048B2")]
		public RoguelikeNodeViewData viewData
		{
			[Token(Token = "0x601F191")]
			[Address(RVA = "0x18D3510", Offset = "0x18D2110", VA = "0x1818D3510")]
			get
			{
				return null;
			}
		}

		// Token: 0x170048B3 RID: 18611
		// (get) Token: 0x0601F192 RID: 127378 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170048B3")]
		public RoguelikeDungeonNodeView.Settings settings
		{
			[Token(Token = "0x601F192")]
			[Address(RVA = "0x18D32D0", Offset = "0x18D1ED0", VA = "0x1818D32D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170048B4 RID: 18612
		// (get) Token: 0x0601F193 RID: 127379 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170048B4")]
		public UIColorGraphic colorGraphic
		{
			[Token(Token = "0x601F193")]
			[Address(RVA = "0x18D24C0", Offset = "0x18D10C0", VA = "0x1818D24C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170048B5 RID: 18613
		// (get) Token: 0x0601F194 RID: 127380 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170048B5")]
		public AnimationWrapper animationWrapper
		{
			[Token(Token = "0x601F194")]
			[Address(RVA = "0x18D22B0", Offset = "0x18D0EB0", VA = "0x1818D22B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170048B6 RID: 18614
		// (get) Token: 0x0601F195 RID: 127381 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170048B6")]
		public AnimationWrapper curveAnimationWrapper
		{
			[Token(Token = "0x601F195")]
			[Address(RVA = "0x18D2580", Offset = "0x18D1180", VA = "0x1818D2580")]
			get
			{
				return null;
			}
		}

		// Token: 0x170048B7 RID: 18615
		// (get) Token: 0x0601F196 RID: 127382 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170048B7")]
		public AnimationWrapper vertAnimationWrapper
		{
			[Token(Token = "0x601F196")]
			[Address(RVA = "0x18D3450", Offset = "0x18D2050", VA = "0x1818D3450")]
			get
			{
				return null;
			}
		}

		// Token: 0x170048B8 RID: 18616
		// (get) Token: 0x0601F197 RID: 127383 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170048B8")]
		public AnimationWrapper connectorAnimationWrapper
		{
			[Token(Token = "0x601F197")]
			[Address(RVA = "0x18D2520", Offset = "0x18D1120", VA = "0x1818D2520")]
			get
			{
				return null;
			}
		}

		// Token: 0x170048B9 RID: 18617
		// (get) Token: 0x0601F198 RID: 127384 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170048B9")]
		public RoguelikeVerticalLine vertLine
		{
			[Token(Token = "0x601F198")]
			[Address(RVA = "0x18D34B0", Offset = "0x18D20B0", VA = "0x1818D34B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170048BA RID: 18618
		// (get) Token: 0x0601F199 RID: 127385 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170048BA")]
		public RectTransform panelFromConnectors
		{
			[Token(Token = "0x601F199")]
			[Address(RVA = "0x18D30C0", Offset = "0x18D1CC0", VA = "0x1818D30C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170048BB RID: 18619
		// (get) Token: 0x0601F19A RID: 127386 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170048BB")]
		public RectTransform panelToConnectors
		{
			[Token(Token = "0x601F19A")]
			[Address(RVA = "0x18D3180", Offset = "0x18D1D80", VA = "0x1818D3180")]
			get
			{
				return null;
			}
		}

		// Token: 0x170048BC RID: 18620
		// (get) Token: 0x0601F19B RID: 127387 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170048BC")]
		public List<RoguelikeConnector> fromConnectors
		{
			[Token(Token = "0x601F19B")]
			[Address(RVA = "0x18D26A0", Offset = "0x18D12A0", VA = "0x1818D26A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170048BD RID: 18621
		// (get) Token: 0x0601F19C RID: 127388 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170048BD")]
		public List<Image> fromReflectConnectors
		{
			[Token(Token = "0x601F19C")]
			[Address(RVA = "0x18D2700", Offset = "0x18D1300", VA = "0x1818D2700")]
			get
			{
				return null;
			}
		}

		// Token: 0x170048BE RID: 18622
		// (get) Token: 0x0601F19D RID: 127389 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170048BE")]
		public List<Image> toConnectors
		{
			[Token(Token = "0x601F19D")]
			[Address(RVA = "0x18D3390", Offset = "0x18D1F90", VA = "0x1818D3390")]
			get
			{
				return null;
			}
		}

		// Token: 0x170048BF RID: 18623
		// (get) Token: 0x0601F19E RID: 127390 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170048BF")]
		public List<RoguelikeCurve> curves
		{
			[Token(Token = "0x601F19E")]
			[Address(RVA = "0x18D25E0", Offset = "0x18D11E0", VA = "0x1818D25E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170048C0 RID: 18624
		// (get) Token: 0x0601F19F RID: 127391 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170048C0")]
		public Image imageBkg
		{
			[Token(Token = "0x601F19F")]
			[Address(RVA = "0x18D27C0", Offset = "0x18D13C0", VA = "0x1818D27C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170048C1 RID: 18625
		// (get) Token: 0x0601F1A0 RID: 127392 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170048C1")]
		public Image imageSelectableBkg
		{
			[Token(Token = "0x601F1A0")]
			[Address(RVA = "0x18D29A0", Offset = "0x18D15A0", VA = "0x1818D29A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170048C2 RID: 18626
		// (get) Token: 0x0601F1A1 RID: 127393 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170048C2")]
		public Image imageBlurBkg
		{
			[Token(Token = "0x601F1A1")]
			[Address(RVA = "0x18D2820", Offset = "0x18D1420", VA = "0x1818D2820")]
			get
			{
				return null;
			}
		}

		// Token: 0x170048C3 RID: 18627
		// (get) Token: 0x0601F1A2 RID: 127394 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170048C3")]
		public Image imageIcon
		{
			[Token(Token = "0x601F1A2")]
			[Address(RVA = "0x18D2940", Offset = "0x18D1540", VA = "0x1818D2940")]
			get
			{
				return null;
			}
		}

		// Token: 0x170048C4 RID: 18628
		// (get) Token: 0x0601F1A3 RID: 127395 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170048C4")]
		public Image imageBoss
		{
			[Token(Token = "0x601F1A3")]
			[Address(RVA = "0x18D28E0", Offset = "0x18D14E0", VA = "0x1818D28E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170048C5 RID: 18629
		// (get) Token: 0x0601F1A4 RID: 127396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170048C5")]
		public Image imageBossIcon
		{
			[Token(Token = "0x601F1A4")]
			[Address(RVA = "0x18D2880", Offset = "0x18D1480", VA = "0x1818D2880")]
			get
			{
				return null;
			}
		}

		// Token: 0x170048C6 RID: 18630
		// (get) Token: 0x0601F1A5 RID: 127397 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170048C6")]
		public Image imageTag
		{
			[Token(Token = "0x601F1A5")]
			[Address(RVA = "0x18D2A00", Offset = "0x18D1600", VA = "0x1818D2A00")]
			get
			{
				return null;
			}
		}

		// Token: 0x170048C7 RID: 18631
		// (get) Token: 0x0601F1A6 RID: 127398 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170048C7")]
		public Image panelColorDesc
		{
			[Token(Token = "0x601F1A6")]
			[Address(RVA = "0x18D3060", Offset = "0x18D1C60", VA = "0x1818D3060")]
			get
			{
				return null;
			}
		}

		// Token: 0x170048C8 RID: 18632
		// (get) Token: 0x0601F1A7 RID: 127399 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170048C8")]
		public Image panelBlackDesc
		{
			[Token(Token = "0x601F1A7")]
			[Address(RVA = "0x18D3000", Offset = "0x18D1C00", VA = "0x1818D3000")]
			get
			{
				return null;
			}
		}

		// Token: 0x170048C9 RID: 18633
		// (get) Token: 0x0601F1A8 RID: 127400 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170048C9")]
		public RectTransform panelNext
		{
			[Token(Token = "0x601F1A8")]
			[Address(RVA = "0x18D3120", Offset = "0x18D1D20", VA = "0x1818D3120")]
			get
			{
				return null;
			}
		}

		// Token: 0x170048CA RID: 18634
		// (get) Token: 0x0601F1A9 RID: 127401 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170048CA")]
		public ParticleSystem particleSystem
		{
			[Token(Token = "0x601F1A9")]
			[Address(RVA = "0x18D31E0", Offset = "0x18D1DE0", VA = "0x1818D31E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170048CB RID: 18635
		// (get) Token: 0x0601F1AA RID: 127402 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170048CB")]
		public Text textName
		{
			[Token(Token = "0x601F1AA")]
			[Address(RVA = "0x18D3330", Offset = "0x18D1F30", VA = "0x1818D3330")]
			get
			{
				return null;
			}
		}

		// Token: 0x170048CC RID: 18636
		// (get) Token: 0x0601F1AB RID: 127403 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170048CC")]
		public Button buttonSelf
		{
			[Token(Token = "0x601F1AB")]
			[Address(RVA = "0x18D23A0", Offset = "0x18D0FA0", VA = "0x1818D23A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170048CD RID: 18637
		// (get) Token: 0x0601F1AC RID: 127404 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170048CD")]
		public GameObject haveLockedInfo
		{
			[Token(Token = "0x601F1AC")]
			[Address(RVA = "0x18D2760", Offset = "0x18D1360", VA = "0x1818D2760")]
			get
			{
				return null;
			}
		}

		// Token: 0x170048CE RID: 18638
		// (get) Token: 0x0601F1AD RID: 127405 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170048CE")]
		public Image isBattleIcon
		{
			[Token(Token = "0x601F1AD")]
			[Address(RVA = "0x18D2A60", Offset = "0x18D1660", VA = "0x1818D2A60")]
			get
			{
				return null;
			}
		}

		// Token: 0x170048CF RID: 18639
		// (get) Token: 0x0601F1AE RID: 127406 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170048CF")]
		public RoguelikeDungeonNode cacheNode
		{
			[Token(Token = "0x601F1AE")]
			[Address(RVA = "0x18D2400", Offset = "0x18D1000", VA = "0x1818D2400")]
			get
			{
				return null;
			}
		}

		// Token: 0x170048D0 RID: 18640
		// (get) Token: 0x0601F1AF RID: 127407 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170048D0")]
		public string topicId
		{
			[Token(Token = "0x601F1AF")]
			[Address(RVA = "0x18D33F0", Offset = "0x18D1FF0", VA = "0x1818D33F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170048D1 RID: 18641
		// (get) Token: 0x0601F1B0 RID: 127408 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170048D1")]
		public Coroutine animCoroutine
		{
			[Token(Token = "0x601F1B0")]
			[Address(RVA = "0x18D2250", Offset = "0x18D0E50", VA = "0x1818D2250")]
			get
			{
				return null;
			}
		}

		// Token: 0x170048D2 RID: 18642
		// (get) Token: 0x0601F1B1 RID: 127409 RVA: 0x000B0E08 File Offset: 0x000AF008
		[Token(Token = "0x170048D2")]
		public bool isBoss
		{
			[Token(Token = "0x601F1B1")]
			[Address(RVA = "0x18D2B20", Offset = "0x18D1720", VA = "0x1818D2B20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170048D3 RID: 18643
		// (get) Token: 0x0601F1B2 RID: 127410 RVA: 0x000B0E20 File Offset: 0x000AF020
		[Token(Token = "0x170048D3")]
		public bool isFinalBoss
		{
			[Token(Token = "0x601F1B2")]
			[Address(RVA = "0x18D2C40", Offset = "0x18D1840", VA = "0x1818D2C40")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170048D4 RID: 18644
		// (get) Token: 0x0601F1B3 RID: 127411 RVA: 0x000B0E38 File Offset: 0x000AF038
		[Token(Token = "0x170048D4")]
		public bool isBattle
		{
			[Token(Token = "0x601F1B3")]
			[Address(RVA = "0x18D2AC0", Offset = "0x18D16C0", VA = "0x1818D2AC0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170048D5 RID: 18645
		// (get) Token: 0x0601F1B4 RID: 127412 RVA: 0x000B0E50 File Offset: 0x000AF050
		[Token(Token = "0x170048D5")]
		public bool isCurrent
		{
			[Token(Token = "0x601F1B4")]
			[Address(RVA = "0x18D2B80", Offset = "0x18D1780", VA = "0x1818D2B80")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170048D6 RID: 18646
		// (get) Token: 0x0601F1B5 RID: 127413 RVA: 0x000B0E68 File Offset: 0x000AF068
		[Token(Token = "0x170048D6")]
		public bool isDiscarded
		{
			[Token(Token = "0x601F1B5")]
			[Address(RVA = "0x18D2BE0", Offset = "0x18D17E0", VA = "0x1818D2BE0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170048D7 RID: 18647
		// (get) Token: 0x0601F1B6 RID: 127414 RVA: 0x000B0E80 File Offset: 0x000AF080
		[Token(Token = "0x170048D7")]
		public bool isFuture
		{
			[Token(Token = "0x601F1B6")]
			[Address(RVA = "0x18D2CA0", Offset = "0x18D18A0", VA = "0x1818D2CA0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170048D8 RID: 18648
		// (get) Token: 0x0601F1B7 RID: 127415 RVA: 0x000B0E98 File Offset: 0x000AF098
		[Token(Token = "0x170048D8")]
		public bool isSelectable
		{
			[Token(Token = "0x601F1B7")]
			[Address(RVA = "0x18D2E20", Offset = "0x18D1A20", VA = "0x1818D2E20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170048D9 RID: 18649
		// (get) Token: 0x0601F1B8 RID: 127416 RVA: 0x000B0EB0 File Offset: 0x000AF0B0
		[Token(Token = "0x170048D9")]
		public bool needParticles
		{
			[Token(Token = "0x601F1B8")]
			[Address(RVA = "0x18D2E80", Offset = "0x18D1A80", VA = "0x1818D2E80")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170048DA RID: 18650
		// (get) Token: 0x0601F1B9 RID: 127417 RVA: 0x000B0EC8 File Offset: 0x000AF0C8
		[Token(Token = "0x170048DA")]
		public bool isInTrace
		{
			[Token(Token = "0x601F1B9")]
			[Address(RVA = "0x18D2D60", Offset = "0x18D1960", VA = "0x1818D2D60")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170048DB RID: 18651
		// (get) Token: 0x0601F1BA RID: 127418 RVA: 0x000B0EE0 File Offset: 0x000AF0E0
		[Token(Token = "0x170048DB")]
		public bool isLocked
		{
			[Token(Token = "0x601F1BA")]
			[Address(RVA = "0x18D2DC0", Offset = "0x18D19C0", VA = "0x1818D2DC0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170048DC RID: 18652
		// (get) Token: 0x0601F1BB RID: 127419 RVA: 0x000B0EF8 File Offset: 0x000AF0F8
		[Token(Token = "0x170048DC")]
		public Color selectableColor
		{
			[Token(Token = "0x601F1BB")]
			[Address(RVA = "0x18D3240", Offset = "0x18D1E40", VA = "0x1818D3240")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x170048DD RID: 18653
		// (get) Token: 0x0601F1BC RID: 127420 RVA: 0x000B0F10 File Offset: 0x000AF110
		[Token(Token = "0x170048DD")]
		public Color bottomBarColor
		{
			[Token(Token = "0x601F1BC")]
			[Address(RVA = "0x18D2310", Offset = "0x18D0F10", VA = "0x1818D2310")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x170048DE RID: 18654
		// (get) Token: 0x0601F1BD RID: 127421 RVA: 0x000B0F28 File Offset: 0x000AF128
		[Token(Token = "0x170048DE")]
		public bool needToPlayVertUpAnim
		{
			[Token(Token = "0x601F1BD")]
			[Address(RVA = "0x18D2F40", Offset = "0x18D1B40", VA = "0x1818D2F40")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170048DF RID: 18655
		// (get) Token: 0x0601F1BE RID: 127422 RVA: 0x000B0F40 File Offset: 0x000AF140
		[Token(Token = "0x170048DF")]
		public bool needToPlayVertDownAnim
		{
			[Token(Token = "0x601F1BE")]
			[Address(RVA = "0x18D2EE0", Offset = "0x18D1AE0", VA = "0x1818D2EE0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170048E0 RID: 18656
		// (get) Token: 0x0601F1BF RID: 127423 RVA: 0x000B0F58 File Offset: 0x000AF158
		[Token(Token = "0x170048E0")]
		public bool isInDiffDisplayZone
		{
			[Token(Token = "0x601F1BF")]
			[Address(RVA = "0x18D2D00", Offset = "0x18D1900", VA = "0x1818D2D00")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170048E1 RID: 18657
		// (get) Token: 0x0601F1C0 RID: 127424 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170048E1")]
		public GameObject cacheParticle
		{
			[Token(Token = "0x601F1C0")]
			[Address(RVA = "0x18D2460", Offset = "0x18D1060", VA = "0x1818D2460")]
			get
			{
				return null;
			}
		}

		// Token: 0x170048E2 RID: 18658
		// (get) Token: 0x0601F1C1 RID: 127425 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170048E2")]
		public RoguelikeDungeonNodeView.EffectCache effectCache
		{
			[Token(Token = "0x601F1C1")]
			[Address(RVA = "0x18D2640", Offset = "0x18D1240", VA = "0x1818D2640")]
			get
			{
				return null;
			}
		}

		// Token: 0x170048E3 RID: 18659
		// (get) Token: 0x0601F1C2 RID: 127426 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601F1C3 RID: 127427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170048E3")]
		public Action<RoguelikeDungeonNode, Bounds> onClicked
		{
			[Token(Token = "0x601F1C2")]
			[Address(RVA = "0x18D2FA0", Offset = "0x18D1BA0", VA = "0x1818D2FA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601F1C3")]
			[Address(RVA = "0x18D3610", Offset = "0x18D2210", VA = "0x1818D3610")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170048E4 RID: 18660
		// (set) Token: 0x0601F1C4 RID: 127428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170048E4")]
		public bool isVisible
		{
			[Token(Token = "0x601F1C4")]
			[Address(RVA = "0x18D3570", Offset = "0x18D2170", VA = "0x1818D3570")]
			set
			{
			}
		}

		// Token: 0x0601F1C5 RID: 127429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F1C5")]
		[Address(RVA = "0x18D0770", Offset = "0x18CF370", VA = "0x1818D0770")]
		public void EventOnClicked()
		{
		}

		// Token: 0x0601F1C6 RID: 127430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F1C6")]
		[Address(RVA = "0x18D0460", Offset = "0x18CF060", VA = "0x1818D0460")]
		public void AnimationEventOnPlayParticle()
		{
		}

		// Token: 0x0601F1C7 RID: 127431 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F1C7")]
		[Address(RVA = "0x18D0A20", Offset = "0x18CF620", VA = "0x1818D0A20")]
		public RectTransform GetConnector(bool isFromConnector, int index)
		{
			return null;
		}

		// Token: 0x0601F1C8 RID: 127432 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F1C8")]
		[Address(RVA = "0x18D0D50", Offset = "0x18CF950", VA = "0x1818D0D50")]
		public RoguelikeVerticalLine GetVertLine()
		{
			return null;
		}

		// Token: 0x0601F1C9 RID: 127433 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F1C9")]
		[Address(RVA = "0x18D0B60", Offset = "0x18CF760", VA = "0x1818D0B60")]
		public RoguelikeCurve GetCurve(int index)
		{
			return null;
		}

		// Token: 0x0601F1CA RID: 127434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F1CA")]
		[Address(RVA = "0x18D1A80", Offset = "0x18D0680", VA = "0x1818D1A80")]
		public void Render(string topicId, RoguelikeDungeonNode node)
		{
		}

		// Token: 0x0601F1CB RID: 127435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F1CB")]
		[Address(RVA = "0x18D1E30", Offset = "0x18D0A30", VA = "0x1818D1E30")]
		private void _PreprocessData()
		{
		}

		// Token: 0x0601F1CC RID: 127436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F1CC")]
		[Address(RVA = "0x18D08D0", Offset = "0x18CF4D0", VA = "0x1818D08D0", Slot = "6")]
		protected virtual void GetColorData()
		{
		}

		// Token: 0x0601F1CD RID: 127437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F1CD")]
		[Address(RVA = "0x18D1F70", Offset = "0x18D0B70", VA = "0x1818D1F70")]
		private void _ResetAnim()
		{
		}

		// Token: 0x0601F1CE RID: 127438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F1CE")]
		[Address(RVA = "0x18D1100", Offset = "0x18CFD00", VA = "0x1818D1100", Slot = "7")]
		protected virtual void RenderBossWidgets()
		{
		}

		// Token: 0x0601F1CF RID: 127439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F1CF")]
		[Address(RVA = "0x18D1220", Offset = "0x18CFE20", VA = "0x1818D1220", Slot = "8")]
		protected virtual void RenderNonBossWidigets()
		{
		}

		// Token: 0x0601F1D0 RID: 127440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F1D0")]
		[Address(RVA = "0x18D0500", Offset = "0x18CF100", VA = "0x1818D0500")]
		public void ClearEffect()
		{
		}

		// Token: 0x0601F1D1 RID: 127441 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F1D1")]
		[Address(RVA = "0x18D1610", Offset = "0x18D0210", VA = "0x1818D1610", Slot = "9")]
		protected virtual void RenderVertLines()
		{
		}

		// Token: 0x0601F1D2 RID: 127442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F1D2")]
		[Address(RVA = "0x18D1190", Offset = "0x18CFD90", VA = "0x1818D1190", Slot = "10")]
		protected virtual void RenderCurves()
		{
		}

		// Token: 0x0601F1D3 RID: 127443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F1D3")]
		[Address(RVA = "0x18D1340", Offset = "0x18CFF40", VA = "0x1818D1340", Slot = "11")]
		protected virtual void RenderParticles()
		{
		}

		// Token: 0x0601F1D4 RID: 127444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F1D4")]
		[Address(RVA = "0x18D12B0", Offset = "0x18CFEB0", VA = "0x1818D12B0", Slot = "12")]
		protected virtual void RenderOtherWidgets()
		{
		}

		// Token: 0x0601F1D5 RID: 127445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F1D5")]
		[Address(RVA = "0x18D0EB0", Offset = "0x18CFAB0", VA = "0x1818D0EB0", Slot = "13")]
		protected virtual void PlayAnim()
		{
		}

		// Token: 0x0601F1D6 RID: 127446 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F1D6")]
		[Address(RVA = "0x18D2140", Offset = "0x18D0D40", VA = "0x1818D2140")]
		private IEnumerator _UpdateAnim()
		{
			return null;
		}

		// Token: 0x0601F1D7 RID: 127447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F1D7")]
		[Address(RVA = "0x18D0DB0", Offset = "0x18CF9B0", VA = "0x1818D0DB0")]
		public void OnDisable()
		{
		}

		// Token: 0x0601F1D8 RID: 127448 RVA: 0x000B0F70 File Offset: 0x000AF170
		[Token(Token = "0x601F1D8")]
		[Address(RVA = "0x18D0C90", Offset = "0x18CF890", VA = "0x1818D0C90", Slot = "4")]
		public Color GetSelectableColor()
		{
			return default(Color);
		}

		// Token: 0x0601F1D9 RID: 127449 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F1D9")]
		[Address(RVA = "0x18D0C30", Offset = "0x18CF830", VA = "0x1818D0C30", Slot = "5")]
		public RectTransform GetRectTransform()
		{
			return null;
		}

		// Token: 0x0601F1DA RID: 127450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F1DA")]
		[Address(RVA = "0x18D21F0", Offset = "0x18D0DF0", VA = "0x1818D21F0")]
		public RoguelikeDungeonNodeView()
		{
		}

		// Token: 0x04029B7D RID: 170877
		[Token(Token = "0x4029B7D")]
		private const string ANIM_CURRENT_NODE = "anim_current_node";

		// Token: 0x04029B7E RID: 170878
		[Token(Token = "0x4029B7E")]
		private const string ANIM_SELECTABLE_NODE = "anim_selectable_node";

		// Token: 0x04029B7F RID: 170879
		[Token(Token = "0x4029B7F")]
		private const string ANIM_CURVE = "anim_curve";

		// Token: 0x04029B80 RID: 170880
		[Token(Token = "0x4029B80")]
		private const string ANIM_VERTI_UP = "up_anim_verti";

		// Token: 0x04029B81 RID: 170881
		[Token(Token = "0x4029B81")]
		private const string ANIM_VERTI_DOWN = "down_anim_verti";

		// Token: 0x04029B82 RID: 170882
		[Token(Token = "0x4029B82")]
		private const string ANIM_CONNECTOR = "anim_connector";

		// Token: 0x04029B83 RID: 170883
		[Token(Token = "0x4029B83")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RoguelikeNodeViewData _viewData;

		// Token: 0x04029B84 RID: 170884
		[Token(Token = "0x4029B84")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RoguelikeDungeonNodeView.Settings _settings;

		// Token: 0x04029B85 RID: 170885
		[Token(Token = "0x4029B85")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIColorGraphic _colorGraphic;

		// Token: 0x04029B86 RID: 170886
		[Token(Token = "0x4029B86")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private AnimationWrapper _animationWrapper;

		// Token: 0x04029B87 RID: 170887
		[Token(Token = "0x4029B87")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private AnimationWrapper _curveAnimationWrapper;

		// Token: 0x04029B88 RID: 170888
		[Token(Token = "0x4029B88")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private AnimationWrapper _vertAnimationWrapper;

		// Token: 0x04029B89 RID: 170889
		[Token(Token = "0x4029B89")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private AnimationWrapper _connectorAnimationWrapper;

		// Token: 0x04029B8A RID: 170890
		[Token(Token = "0x4029B8A")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private RoguelikeVerticalLine _vertLine;

		// Token: 0x04029B8B RID: 170891
		[Token(Token = "0x4029B8B")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private RectTransform _panelFromConnectors;

		// Token: 0x04029B8C RID: 170892
		[Token(Token = "0x4029B8C")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private RectTransform _panelToConnectors;

		// Token: 0x04029B8D RID: 170893
		[Token(Token = "0x4029B8D")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private List<RoguelikeConnector> _fromConnectors;

		// Token: 0x04029B8E RID: 170894
		[Token(Token = "0x4029B8E")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private List<Image> _fromReflectConnectors;

		// Token: 0x04029B8F RID: 170895
		[Token(Token = "0x4029B8F")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private List<Image> _toConnectors;

		// Token: 0x04029B90 RID: 170896
		[Token(Token = "0x4029B90")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private List<RoguelikeCurve> _curves;

		// Token: 0x04029B91 RID: 170897
		[Token(Token = "0x4029B91")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Image _imageBkg;

		// Token: 0x04029B92 RID: 170898
		[Token(Token = "0x4029B92")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Image _imageSelectableBkg;

		// Token: 0x04029B93 RID: 170899
		[Token(Token = "0x4029B93")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Image _imageBlurBkg;

		// Token: 0x04029B94 RID: 170900
		[Token(Token = "0x4029B94")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Image _imageIcon;

		// Token: 0x04029B95 RID: 170901
		[Token(Token = "0x4029B95")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Image _imageBoss;

		// Token: 0x04029B96 RID: 170902
		[Token(Token = "0x4029B96")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private Image _imageBossIcon;

		// Token: 0x04029B97 RID: 170903
		[Token(Token = "0x4029B97")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private Image _imageTag;

		// Token: 0x04029B98 RID: 170904
		[Token(Token = "0x4029B98")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private Image _panelColorDesc;

		// Token: 0x04029B99 RID: 170905
		[Token(Token = "0x4029B99")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private Image _panelBlackDesc;

		// Token: 0x04029B9A RID: 170906
		[Token(Token = "0x4029B9A")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private RectTransform _panelNext;

		// Token: 0x04029B9B RID: 170907
		[Token(Token = "0x4029B9B")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private ParticleSystem _particleSystem;

		// Token: 0x04029B9C RID: 170908
		[Token(Token = "0x4029B9C")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private Text _textName;

		// Token: 0x04029B9D RID: 170909
		[Token(Token = "0x4029B9D")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private Button _buttonSelf;

		// Token: 0x04029B9E RID: 170910
		[Token(Token = "0x4029B9E")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private GameObject _haveLockedInfo;

		// Token: 0x04029B9F RID: 170911
		[Token(Token = "0x4029B9F")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private Image _isBattleIcon;

		// Token: 0x04029BA0 RID: 170912
		[Token(Token = "0x4029BA0")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private RoguelikeDungeonNodePlugin _plugin;

		// Token: 0x04029BA1 RID: 170913
		[Token(Token = "0x4029BA1")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private RoguelikeDungeonNodeView.RogueLogic _logic;

		// Token: 0x04029BA2 RID: 170914
		[Token(Token = "0x4029BA2")]
		[FieldOffset(Offset = "0x110")]
		private RoguelikeDungeonNode m_cacheNode;

		// Token: 0x04029BA3 RID: 170915
		[Token(Token = "0x4029BA3")]
		[FieldOffset(Offset = "0x118")]
		private string m_topicId;

		// Token: 0x04029BA4 RID: 170916
		[Token(Token = "0x4029BA4")]
		[FieldOffset(Offset = "0x120")]
		private Coroutine m_animCoroutine;

		// Token: 0x04029BA5 RID: 170917
		[Token(Token = "0x4029BA5")]
		[FieldOffset(Offset = "0x128")]
		private bool m_isBoss;

		// Token: 0x04029BA6 RID: 170918
		[Token(Token = "0x4029BA6")]
		[FieldOffset(Offset = "0x129")]
		private bool m_isFinalBoss;

		// Token: 0x04029BA7 RID: 170919
		[Token(Token = "0x4029BA7")]
		[FieldOffset(Offset = "0x12A")]
		private bool m_isBattle;

		// Token: 0x04029BA8 RID: 170920
		[Token(Token = "0x4029BA8")]
		[FieldOffset(Offset = "0x12B")]
		private bool m_isCurrent;

		// Token: 0x04029BA9 RID: 170921
		[Token(Token = "0x4029BA9")]
		[FieldOffset(Offset = "0x12C")]
		private bool m_isDiscarded;

		// Token: 0x04029BAA RID: 170922
		[Token(Token = "0x4029BAA")]
		[FieldOffset(Offset = "0x12D")]
		private bool m_isFuture;

		// Token: 0x04029BAB RID: 170923
		[Token(Token = "0x4029BAB")]
		[FieldOffset(Offset = "0x12E")]
		private bool m_isSelectable;

		// Token: 0x04029BAC RID: 170924
		[Token(Token = "0x4029BAC")]
		[FieldOffset(Offset = "0x12F")]
		private bool m_needParticles;

		// Token: 0x04029BAD RID: 170925
		[Token(Token = "0x4029BAD")]
		[FieldOffset(Offset = "0x130")]
		private bool m_isInTrace;

		// Token: 0x04029BAE RID: 170926
		[Token(Token = "0x4029BAE")]
		[FieldOffset(Offset = "0x131")]
		private bool m_isLocked;

		// Token: 0x04029BAF RID: 170927
		[Token(Token = "0x4029BAF")]
		[FieldOffset(Offset = "0x134")]
		private Color m_selectableColor;

		// Token: 0x04029BB0 RID: 170928
		[Token(Token = "0x4029BB0")]
		[FieldOffset(Offset = "0x144")]
		private Color m_bottomBarColor;

		// Token: 0x04029BB1 RID: 170929
		[Token(Token = "0x4029BB1")]
		[FieldOffset(Offset = "0x154")]
		private bool m_needToPlayVertUpAnim;

		// Token: 0x04029BB2 RID: 170930
		[Token(Token = "0x4029BB2")]
		[FieldOffset(Offset = "0x155")]
		private bool m_needToPlayVertDownAnim;

		// Token: 0x04029BB3 RID: 170931
		[Token(Token = "0x4029BB3")]
		[FieldOffset(Offset = "0x156")]
		private bool m_isInDiffDisplayZone;

		// Token: 0x04029BB4 RID: 170932
		[Token(Token = "0x4029BB4")]
		[FieldOffset(Offset = "0x158")]
		private GameObject m_cacheParticle;

		// Token: 0x04029BB5 RID: 170933
		[Token(Token = "0x4029BB5")]
		[FieldOffset(Offset = "0x160")]
		private RoguelikeDungeonNodeView.EffectCache m_effectCache;

		// Token: 0x04029BB7 RID: 170935
		[Token(Token = "0x4029BB7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_viewData;

		// Token: 0x04029BB8 RID: 170936
		[Token(Token = "0x4029BB8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_settings;

		// Token: 0x04029BB9 RID: 170937
		[Token(Token = "0x4029BB9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_colorGraphic;

		// Token: 0x04029BBA RID: 170938
		[Token(Token = "0x4029BBA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_animationWrapper;

		// Token: 0x04029BBB RID: 170939
		[Token(Token = "0x4029BBB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_curveAnimationWrapper;

		// Token: 0x04029BBC RID: 170940
		[Token(Token = "0x4029BBC")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_vertAnimationWrapper;

		// Token: 0x04029BBD RID: 170941
		[Token(Token = "0x4029BBD")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_connectorAnimationWrapper;

		// Token: 0x04029BBE RID: 170942
		[Token(Token = "0x4029BBE")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_vertLine;

		// Token: 0x04029BBF RID: 170943
		[Token(Token = "0x4029BBF")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_panelFromConnectors;

		// Token: 0x04029BC0 RID: 170944
		[Token(Token = "0x4029BC0")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_panelToConnectors;

		// Token: 0x04029BC1 RID: 170945
		[Token(Token = "0x4029BC1")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_fromConnectors;

		// Token: 0x04029BC2 RID: 170946
		[Token(Token = "0x4029BC2")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_fromReflectConnectors;

		// Token: 0x04029BC3 RID: 170947
		[Token(Token = "0x4029BC3")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_toConnectors;

		// Token: 0x04029BC4 RID: 170948
		[Token(Token = "0x4029BC4")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_get_curves;

		// Token: 0x04029BC5 RID: 170949
		[Token(Token = "0x4029BC5")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_get_imageBkg;

		// Token: 0x04029BC6 RID: 170950
		[Token(Token = "0x4029BC6")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_get_imageSelectableBkg;

		// Token: 0x04029BC7 RID: 170951
		[Token(Token = "0x4029BC7")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_get_imageBlurBkg;

		// Token: 0x04029BC8 RID: 170952
		[Token(Token = "0x4029BC8")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_get_imageIcon;

		// Token: 0x04029BC9 RID: 170953
		[Token(Token = "0x4029BC9")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_get_imageBoss;

		// Token: 0x04029BCA RID: 170954
		[Token(Token = "0x4029BCA")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_get_imageBossIcon;

		// Token: 0x04029BCB RID: 170955
		[Token(Token = "0x4029BCB")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_get_imageTag;

		// Token: 0x04029BCC RID: 170956
		[Token(Token = "0x4029BCC")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_get_panelColorDesc;

		// Token: 0x04029BCD RID: 170957
		[Token(Token = "0x4029BCD")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_get_panelBlackDesc;

		// Token: 0x04029BCE RID: 170958
		[Token(Token = "0x4029BCE")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_get_panelNext;

		// Token: 0x04029BCF RID: 170959
		[Token(Token = "0x4029BCF")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_get_particleSystem;

		// Token: 0x04029BD0 RID: 170960
		[Token(Token = "0x4029BD0")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_get_textName;

		// Token: 0x04029BD1 RID: 170961
		[Token(Token = "0x4029BD1")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_get_buttonSelf;

		// Token: 0x04029BD2 RID: 170962
		[Token(Token = "0x4029BD2")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_get_haveLockedInfo;

		// Token: 0x04029BD3 RID: 170963
		[Token(Token = "0x4029BD3")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_get_isBattleIcon;

		// Token: 0x04029BD4 RID: 170964
		[Token(Token = "0x4029BD4")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_get_cacheNode;

		// Token: 0x04029BD5 RID: 170965
		[Token(Token = "0x4029BD5")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_get_topicId;

		// Token: 0x04029BD6 RID: 170966
		[Token(Token = "0x4029BD6")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_get_animCoroutine;

		// Token: 0x04029BD7 RID: 170967
		[Token(Token = "0x4029BD7")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_get_isBoss;

		// Token: 0x04029BD8 RID: 170968
		[Token(Token = "0x4029BD8")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_get_isFinalBoss;

		// Token: 0x04029BD9 RID: 170969
		[Token(Token = "0x4029BD9")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_get_isBattle;

		// Token: 0x04029BDA RID: 170970
		[Token(Token = "0x4029BDA")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_get_isCurrent;

		// Token: 0x04029BDB RID: 170971
		[Token(Token = "0x4029BDB")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0_get_isDiscarded;

		// Token: 0x04029BDC RID: 170972
		[Token(Token = "0x4029BDC")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0_get_isFuture;

		// Token: 0x04029BDD RID: 170973
		[Token(Token = "0x4029BDD")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0_get_isSelectable;

		// Token: 0x04029BDE RID: 170974
		[Token(Token = "0x4029BDE")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0_get_needParticles;

		// Token: 0x04029BDF RID: 170975
		[Token(Token = "0x4029BDF")]
		[FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0_get_isInTrace;

		// Token: 0x04029BE0 RID: 170976
		[Token(Token = "0x4029BE0")]
		[FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0_get_isLocked;

		// Token: 0x04029BE1 RID: 170977
		[Token(Token = "0x4029BE1")]
		[FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0_get_selectableColor;

		// Token: 0x04029BE2 RID: 170978
		[Token(Token = "0x4029BE2")]
		[FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0_get_bottomBarColor;

		// Token: 0x04029BE3 RID: 170979
		[Token(Token = "0x4029BE3")]
		[FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0_get_needToPlayVertUpAnim;

		// Token: 0x04029BE4 RID: 170980
		[Token(Token = "0x4029BE4")]
		[FieldOffset(Offset = "0x168")]
		private static DelegateBridge __Hotfix0_get_needToPlayVertDownAnim;

		// Token: 0x04029BE5 RID: 170981
		[Token(Token = "0x4029BE5")]
		[FieldOffset(Offset = "0x170")]
		private static DelegateBridge __Hotfix0_get_isInDiffDisplayZone;

		// Token: 0x04029BE6 RID: 170982
		[Token(Token = "0x4029BE6")]
		[FieldOffset(Offset = "0x178")]
		private static DelegateBridge __Hotfix0_get_cacheParticle;

		// Token: 0x04029BE7 RID: 170983
		[Token(Token = "0x4029BE7")]
		[FieldOffset(Offset = "0x180")]
		private static DelegateBridge __Hotfix0_get_effectCache;

		// Token: 0x04029BE8 RID: 170984
		[Token(Token = "0x4029BE8")]
		[FieldOffset(Offset = "0x188")]
		private static DelegateBridge __Hotfix0_get_onClicked;

		// Token: 0x04029BE9 RID: 170985
		[Token(Token = "0x4029BE9")]
		[FieldOffset(Offset = "0x190")]
		private static DelegateBridge __Hotfix0_set_onClicked;

		// Token: 0x04029BEA RID: 170986
		[Token(Token = "0x4029BEA")]
		[FieldOffset(Offset = "0x198")]
		private static DelegateBridge __Hotfix0_set_isVisible;

		// Token: 0x04029BEB RID: 170987
		[Token(Token = "0x4029BEB")]
		[FieldOffset(Offset = "0x1A0")]
		private static DelegateBridge __Hotfix0_EventOnClicked;

		// Token: 0x04029BEC RID: 170988
		[Token(Token = "0x4029BEC")]
		[FieldOffset(Offset = "0x1A8")]
		private static DelegateBridge __Hotfix0_AnimationEventOnPlayParticle;

		// Token: 0x04029BED RID: 170989
		[Token(Token = "0x4029BED")]
		[FieldOffset(Offset = "0x1B0")]
		private static DelegateBridge __Hotfix0_GetConnector;

		// Token: 0x04029BEE RID: 170990
		[Token(Token = "0x4029BEE")]
		[FieldOffset(Offset = "0x1B8")]
		private static DelegateBridge __Hotfix0_GetVertLine;

		// Token: 0x04029BEF RID: 170991
		[Token(Token = "0x4029BEF")]
		[FieldOffset(Offset = "0x1C0")]
		private static DelegateBridge __Hotfix0_GetCurve;

		// Token: 0x04029BF0 RID: 170992
		[Token(Token = "0x4029BF0")]
		[FieldOffset(Offset = "0x1C8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04029BF1 RID: 170993
		[Token(Token = "0x4029BF1")]
		[FieldOffset(Offset = "0x1D0")]
		private static DelegateBridge __Hotfix0__PreprocessData;

		// Token: 0x04029BF2 RID: 170994
		[Token(Token = "0x4029BF2")]
		[FieldOffset(Offset = "0x1D8")]
		private static DelegateBridge __Hotfix0_GetColorData;

		// Token: 0x04029BF3 RID: 170995
		[Token(Token = "0x4029BF3")]
		[FieldOffset(Offset = "0x1E0")]
		private static DelegateBridge __Hotfix0__ResetAnim;

		// Token: 0x04029BF4 RID: 170996
		[Token(Token = "0x4029BF4")]
		[FieldOffset(Offset = "0x1E8")]
		private static DelegateBridge __Hotfix0_RenderBossWidgets;

		// Token: 0x04029BF5 RID: 170997
		[Token(Token = "0x4029BF5")]
		[FieldOffset(Offset = "0x1F0")]
		private static DelegateBridge __Hotfix0_RenderNonBossWidigets;

		// Token: 0x04029BF6 RID: 170998
		[Token(Token = "0x4029BF6")]
		[FieldOffset(Offset = "0x1F8")]
		private static DelegateBridge __Hotfix0_ClearEffect;

		// Token: 0x04029BF7 RID: 170999
		[Token(Token = "0x4029BF7")]
		[FieldOffset(Offset = "0x200")]
		private static DelegateBridge __Hotfix0_RenderVertLines;

		// Token: 0x04029BF8 RID: 171000
		[Token(Token = "0x4029BF8")]
		[FieldOffset(Offset = "0x208")]
		private static DelegateBridge __Hotfix0_RenderCurves;

		// Token: 0x04029BF9 RID: 171001
		[Token(Token = "0x4029BF9")]
		[FieldOffset(Offset = "0x210")]
		private static DelegateBridge __Hotfix0_RenderParticles;

		// Token: 0x04029BFA RID: 171002
		[Token(Token = "0x4029BFA")]
		[FieldOffset(Offset = "0x218")]
		private static DelegateBridge __Hotfix0_RenderOtherWidgets;

		// Token: 0x04029BFB RID: 171003
		[Token(Token = "0x4029BFB")]
		[FieldOffset(Offset = "0x220")]
		private static DelegateBridge __Hotfix0_PlayAnim;

		// Token: 0x04029BFC RID: 171004
		[Token(Token = "0x4029BFC")]
		[FieldOffset(Offset = "0x228")]
		private static DelegateBridge __Hotfix0__UpdateAnim;

		// Token: 0x04029BFD RID: 171005
		[Token(Token = "0x4029BFD")]
		[FieldOffset(Offset = "0x230")]
		private static DelegateBridge __Hotfix0_OnDisable;

		// Token: 0x04029BFE RID: 171006
		[Token(Token = "0x4029BFE")]
		[FieldOffset(Offset = "0x238")]
		private static DelegateBridge __Hotfix0_GetSelectableColor;

		// Token: 0x04029BFF RID: 171007
		[Token(Token = "0x4029BFF")]
		[FieldOffset(Offset = "0x240")]
		private static DelegateBridge __Hotfix0_GetRectTransform;

		// Token: 0x04029C00 RID: 171008
		[Token(Token = "0x4029C00")]
		[FieldOffset(Offset = "0x248")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005261 RID: 21089
		[Token(Token = "0x2005261")]
		public abstract class RogueLogic : MonoBehaviour, IHotfixable
		{
			// Token: 0x0601F1DB RID: 127451
			[Token(Token = "0x601F1DB")]
			public abstract void RenderBossWidgets();

			// Token: 0x0601F1DC RID: 127452
			[Token(Token = "0x601F1DC")]
			public abstract void RenderNonBossWidigets();

			// Token: 0x0601F1DD RID: 127453
			[Token(Token = "0x601F1DD")]
			public abstract void RenderCurves();

			// Token: 0x0601F1DE RID: 127454
			[Token(Token = "0x601F1DE")]
			public abstract void RenderOtherWidgets();

			// Token: 0x0601F1DF RID: 127455 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F1DF")]
			[Address(RVA = "0x18C8230", Offset = "0x18C6E30", VA = "0x1818C8230")]
			protected RogueLogic()
			{
			}

			// Token: 0x04029C01 RID: 171009
			[Token(Token = "0x4029C01")]
			[FieldOffset(Offset = "0x18")]
			[NonSerialized]
			public RoguelikeDungeonNodeView nodeView;

			// Token: 0x04029C02 RID: 171010
			[Token(Token = "0x4029C02")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02005262 RID: 21090
		[Token(Token = "0x2005262")]
		[Serializable]
		public class Settings
		{
			// Token: 0x0601F1E0 RID: 127456 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F1E0")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Settings()
			{
			}

			// Token: 0x04029C03 RID: 171011
			[Token(Token = "0x4029C03")]
			[FieldOffset(Offset = "0x10")]
			public float panelConnectorX;

			// Token: 0x04029C04 RID: 171012
			[Token(Token = "0x4029C04")]
			[FieldOffset(Offset = "0x14")]
			public float panelConnectorXBoss;

			// Token: 0x04029C05 RID: 171013
			[Token(Token = "0x4029C05")]
			[FieldOffset(Offset = "0x18")]
			public float panelNextY;

			// Token: 0x04029C06 RID: 171014
			[Token(Token = "0x4029C06")]
			[FieldOffset(Offset = "0x1C")]
			public float panelNextYBoss;

			// Token: 0x04029C07 RID: 171015
			[Token(Token = "0x4029C07")]
			[FieldOffset(Offset = "0x20")]
			public float nonBattleNodeHotSpotBottomOffset;

			// Token: 0x04029C08 RID: 171016
			[Token(Token = "0x4029C08")]
			[FieldOffset(Offset = "0x24")]
			public float battleNodeHotSpotBottomOffset;
		}

		// Token: 0x02005263 RID: 21091
		[Token(Token = "0x2005263")]
		public class EffectCache
		{
			// Token: 0x0601F1E1 RID: 127457 RVA: 0x000B0F88 File Offset: 0x000AF188
			[Token(Token = "0x601F1E1")]
			[Address(RVA = "0x18C7850", Offset = "0x18C6450", VA = "0x1818C7850")]
			public bool IsSame(RoguelikeEventType i_eventType, PlayerNodeForesightType i_foresightType, bool i_isFinalBoss)
			{
				return default(bool);
			}

			// Token: 0x0601F1E2 RID: 127458 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F1E2")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public EffectCache()
			{
			}

			// Token: 0x04029C09 RID: 171017
			[Token(Token = "0x4029C09")]
			[FieldOffset(Offset = "0x10")]
			public RoguelikeEventType eventType;

			// Token: 0x04029C0A RID: 171018
			[Token(Token = "0x4029C0A")]
			[FieldOffset(Offset = "0x14")]
			public PlayerNodeForesightType foresightType;

			// Token: 0x04029C0B RID: 171019
			[Token(Token = "0x4029C0B")]
			[FieldOffset(Offset = "0x18")]
			public bool isFinalBoss;
		}
	}
}
