using System;
using Il2CppDummyDll;

namespace Spine
{
	// Token: 0x0200003C RID: 60
	[Token(Token = "0x200003C")]
	public class Bone : IUpdatable
	{
		// Token: 0x17000099 RID: 153
		// (get) Token: 0x060001FD RID: 509 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x17000099")]
		public BoneData Data
		{
			[Token(Token = "0x60001FD")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x060001FE RID: 510 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x1700009A")]
		public Skeleton Skeleton
		{
			[Token(Token = "0x60001FE")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x060001FF RID: 511 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x1700009B")]
		public Bone Parent
		{
			[Token(Token = "0x60001FF")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x06000200 RID: 512 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x1700009C")]
		public ExposedList<Bone> Children
		{
			[Token(Token = "0x6000200")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x06000201 RID: 513 RVA: 0x00002BDC File Offset: 0x00000DDC
		[Token(Token = "0x1700009D")]
		public bool Active
		{
			[Token(Token = "0x6000201")]
			[Address(RVA = "0x4E4DA70", Offset = "0x4E4C670", VA = "0x184E4DA70", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x06000202 RID: 514 RVA: 0x00002BF4 File Offset: 0x00000DF4
		// (set) Token: 0x06000203 RID: 515 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x1700009E")]
		public float X
		{
			[Token(Token = "0x6000202")]
			[Address(RVA = "0x4F7D70", Offset = "0x4F6970", VA = "0x1804F7D70")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000203")]
			[Address(RVA = "0x16928D0", Offset = "0x16914D0", VA = "0x1816928D0")]
			set
			{
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x06000204 RID: 516 RVA: 0x00002C0C File Offset: 0x00000E0C
		// (set) Token: 0x06000205 RID: 517 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x1700009F")]
		public float Y
		{
			[Token(Token = "0x6000204")]
			[Address(RVA = "0x16923F0", Offset = "0x1690FF0", VA = "0x1816923F0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000205")]
			[Address(RVA = "0x16928C0", Offset = "0x16914C0", VA = "0x1816928C0")]
			set
			{
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x06000206 RID: 518 RVA: 0x00002C24 File Offset: 0x00000E24
		// (set) Token: 0x06000207 RID: 519 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x170000A0")]
		public float Rotation
		{
			[Token(Token = "0x6000206")]
			[Address(RVA = "0xFB13C0", Offset = "0xFAFFC0", VA = "0x180FB13C0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000207")]
			[Address(RVA = "0x1692890", Offset = "0x1691490", VA = "0x181692890")]
			set
			{
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x06000208 RID: 520 RVA: 0x00002C3C File Offset: 0x00000E3C
		// (set) Token: 0x06000209 RID: 521 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x170000A1")]
		public float ScaleX
		{
			[Token(Token = "0x6000208")]
			[Address(RVA = "0x7CEE20", Offset = "0x7CDA20", VA = "0x1807CEE20")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000209")]
			[Address(RVA = "0x1692880", Offset = "0x1691480", VA = "0x181692880")]
			set
			{
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x0600020A RID: 522 RVA: 0x00002C54 File Offset: 0x00000E54
		// (set) Token: 0x0600020B RID: 523 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x170000A2")]
		public float ScaleY
		{
			[Token(Token = "0x600020A")]
			[Address(RVA = "0x42B1310", Offset = "0x42AFF10", VA = "0x1842B1310")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600020B")]
			[Address(RVA = "0x4469FE0", Offset = "0x4468BE0", VA = "0x184469FE0")]
			set
			{
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x0600020C RID: 524 RVA: 0x00002C6C File Offset: 0x00000E6C
		// (set) Token: 0x0600020D RID: 525 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x170000A3")]
		public float ShearX
		{
			[Token(Token = "0x600020C")]
			[Address(RVA = "0x4E48960", Offset = "0x4E47560", VA = "0x184E48960")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600020D")]
			[Address(RVA = "0x1DE3EA0", Offset = "0x1DE2AA0", VA = "0x181DE3EA0")]
			set
			{
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x0600020E RID: 526 RVA: 0x00002C84 File Offset: 0x00000E84
		// (set) Token: 0x0600020F RID: 527 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x170000A4")]
		public float ShearY
		{
			[Token(Token = "0x600020E")]
			[Address(RVA = "0x17DB8C0", Offset = "0x17DA4C0", VA = "0x1817DB8C0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600020F")]
			[Address(RVA = "0x17DB8D0", Offset = "0x17DA4D0", VA = "0x1817DB8D0")]
			set
			{
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x06000210 RID: 528 RVA: 0x00002C9C File Offset: 0x00000E9C
		// (set) Token: 0x06000211 RID: 529 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x170000A5")]
		public float AppliedRotation
		{
			[Token(Token = "0x6000210")]
			[Address(RVA = "0x1E29290", Offset = "0x1E27E90", VA = "0x181E29290")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000211")]
			[Address(RVA = "0x4E48A80", Offset = "0x4E47680", VA = "0x184E48A80")]
			set
			{
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x06000212 RID: 530 RVA: 0x00002CB4 File Offset: 0x00000EB4
		// (set) Token: 0x06000213 RID: 531 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x170000A6")]
		public float AX
		{
			[Token(Token = "0x6000212")]
			[Address(RVA = "0x17DB8E0", Offset = "0x17DA4E0", VA = "0x1817DB8E0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000213")]
			[Address(RVA = "0x17DB8F0", Offset = "0x17DA4F0", VA = "0x1817DB8F0")]
			set
			{
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x06000214 RID: 532 RVA: 0x00002CCC File Offset: 0x00000ECC
		// (set) Token: 0x06000215 RID: 533 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x170000A7")]
		public float AY
		{
			[Token(Token = "0x6000214")]
			[Address(RVA = "0x1251100", Offset = "0x124FD00", VA = "0x181251100")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000215")]
			[Address(RVA = "0x1692870", Offset = "0x1691470", VA = "0x181692870")]
			set
			{
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x06000216 RID: 534 RVA: 0x00002CE4 File Offset: 0x00000EE4
		// (set) Token: 0x06000217 RID: 535 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x170000A8")]
		public float AScaleX
		{
			[Token(Token = "0x6000216")]
			[Address(RVA = "0x1692360", Offset = "0x1690F60", VA = "0x181692360")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000217")]
			[Address(RVA = "0x1692840", Offset = "0x1691440", VA = "0x181692840")]
			set
			{
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x06000218 RID: 536 RVA: 0x00002CFC File Offset: 0x00000EFC
		// (set) Token: 0x06000219 RID: 537 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x170000A9")]
		public float AScaleY
		{
			[Token(Token = "0x6000218")]
			[Address(RVA = "0x4E4DA40", Offset = "0x4E4C640", VA = "0x184E4DA40")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000219")]
			[Address(RVA = "0x4E4DF20", Offset = "0x4E4CB20", VA = "0x184E4DF20")]
			set
			{
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x0600021A RID: 538 RVA: 0x00002D14 File Offset: 0x00000F14
		// (set) Token: 0x0600021B RID: 539 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x170000AA")]
		public float AShearX
		{
			[Token(Token = "0x600021A")]
			[Address(RVA = "0x4E4DA50", Offset = "0x4E4C650", VA = "0x184E4DA50")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600021B")]
			[Address(RVA = "0x4E4DF30", Offset = "0x4E4CB30", VA = "0x184E4DF30")]
			set
			{
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x0600021C RID: 540 RVA: 0x00002D2C File Offset: 0x00000F2C
		// (set) Token: 0x0600021D RID: 541 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x170000AB")]
		public float AShearY
		{
			[Token(Token = "0x600021C")]
			[Address(RVA = "0x4E4DA60", Offset = "0x4E4C660", VA = "0x184E4DA60")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600021D")]
			[Address(RVA = "0x4E4DF40", Offset = "0x4E4CB40", VA = "0x184E4DF40")]
			set
			{
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x0600021E RID: 542 RVA: 0x00002D44 File Offset: 0x00000F44
		[Token(Token = "0x170000AC")]
		public float A
		{
			[Token(Token = "0x600021E")]
			[Address(RVA = "0x4E40370", Offset = "0x4E3EF70", VA = "0x184E40370")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x0600021F RID: 543 RVA: 0x00002D5C File Offset: 0x00000F5C
		[Token(Token = "0x170000AD")]
		public float B
		{
			[Token(Token = "0x600021F")]
			[Address(RVA = "0x157CF40", Offset = "0x157BB40", VA = "0x18157CF40")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x06000220 RID: 544 RVA: 0x00002D74 File Offset: 0x00000F74
		[Token(Token = "0x170000AE")]
		public float C
		{
			[Token(Token = "0x6000220")]
			[Address(RVA = "0x1EC7FD0", Offset = "0x1EC6BD0", VA = "0x181EC7FD0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x06000221 RID: 545 RVA: 0x00002D8C File Offset: 0x00000F8C
		[Token(Token = "0x170000AF")]
		public float D
		{
			[Token(Token = "0x6000221")]
			[Address(RVA = "0x1692770", Offset = "0x1691370", VA = "0x181692770")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x06000222 RID: 546 RVA: 0x00002DA4 File Offset: 0x00000FA4
		[Token(Token = "0x170000B0")]
		public float WorldX
		{
			[Token(Token = "0x6000222")]
			[Address(RVA = "0x1692750", Offset = "0x1691350", VA = "0x181692750")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x06000223 RID: 547 RVA: 0x00002DBC File Offset: 0x00000FBC
		[Token(Token = "0x170000B1")]
		public float WorldY
		{
			[Token(Token = "0x6000223")]
			[Address(RVA = "0x1692760", Offset = "0x1691360", VA = "0x181692760")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x06000224 RID: 548 RVA: 0x00002DD4 File Offset: 0x00000FD4
		[Token(Token = "0x170000B2")]
		public float WorldRotationX
		{
			[Token(Token = "0x6000224")]
			[Address(RVA = "0x4E4DA80", Offset = "0x4E4C680", VA = "0x184E4DA80")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x06000225 RID: 549 RVA: 0x00002DEC File Offset: 0x00000FEC
		[Token(Token = "0x170000B3")]
		public float WorldRotationY
		{
			[Token(Token = "0x6000225")]
			[Address(RVA = "0x4E4DB30", Offset = "0x4E4C730", VA = "0x184E4DB30")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x06000226 RID: 550 RVA: 0x00002E04 File Offset: 0x00001004
		[Token(Token = "0x170000B4")]
		public float WorldScaleX
		{
			[Token(Token = "0x6000226")]
			[Address(RVA = "0x4E4DBE0", Offset = "0x4E4C7E0", VA = "0x184E4DBE0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x06000227 RID: 551 RVA: 0x00002E1C File Offset: 0x0000101C
		[Token(Token = "0x170000B5")]
		public float WorldScaleY
		{
			[Token(Token = "0x6000227")]
			[Address(RVA = "0x4E4DC80", Offset = "0x4E4C880", VA = "0x184E4DC80")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06000228 RID: 552 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000228")]
		[Address(RVA = "0x4E4D850", Offset = "0x4E4C450", VA = "0x184E4D850")]
		public Bone(BoneData data, Skeleton skeleton, Bone parent)
		{
		}

		// Token: 0x06000229 RID: 553 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000229")]
		[Address(RVA = "0x4E4D5D0", Offset = "0x4E4C1D0", VA = "0x184E4D5D0", Slot = "4")]
		public void Update()
		{
		}

		// Token: 0x0600022A RID: 554 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600022A")]
		[Address(RVA = "0x4E4D5D0", Offset = "0x4E4C1D0", VA = "0x184E4D5D0")]
		public void UpdateWorldTransform()
		{
		}

		// Token: 0x0600022B RID: 555 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600022B")]
		[Address(RVA = "0x4E4C900", Offset = "0x4E4B500", VA = "0x184E4C900")]
		public void UpdateWorldTransform(float x, float y, float rotation, float scaleX, float scaleY, float shearX, float shearY)
		{
		}

		// Token: 0x0600022C RID: 556 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600022C")]
		[Address(RVA = "0x4E4C470", Offset = "0x4E4B070", VA = "0x184E4C470")]
		public void SetToSetupPose()
		{
		}

		// Token: 0x0600022D RID: 557 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600022D")]
		[Address(RVA = "0x4E4C4C0", Offset = "0x4E4B0C0", VA = "0x184E4C4C0")]
		internal void UpdateAppliedTransform()
		{
		}

		// Token: 0x0600022E RID: 558 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600022E")]
		[Address(RVA = "0x4E4D790", Offset = "0x4E4C390", VA = "0x184E4D790")]
		public void WorldToLocal(float worldX, float worldY, out float localX, out float localY)
		{
		}

		// Token: 0x0600022F RID: 559 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600022F")]
		[Address(RVA = "0x4E4C290", Offset = "0x4E4AE90", VA = "0x184E4C290")]
		public void LocalToWorld(float localX, float localY, out float worldX, out float worldY)
		{
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x06000230 RID: 560 RVA: 0x00002E34 File Offset: 0x00001034
		[Token(Token = "0x170000B6")]
		public float WorldToLocalRotationX
		{
			[Token(Token = "0x6000230")]
			[Address(RVA = "0x4E4DD20", Offset = "0x4E4C920", VA = "0x184E4DD20")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x06000231 RID: 561 RVA: 0x00002E4C File Offset: 0x0000104C
		[Token(Token = "0x170000B7")]
		public float WorldToLocalRotationY
		{
			[Token(Token = "0x6000231")]
			[Address(RVA = "0x4E4DE20", Offset = "0x4E4CA20", VA = "0x184E4DE20")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06000232 RID: 562 RVA: 0x00002E64 File Offset: 0x00001064
		[Token(Token = "0x6000232")]
		[Address(RVA = "0x4E4D630", Offset = "0x4E4C230", VA = "0x184E4D630")]
		public float WorldToLocalRotation(float worldRotation)
		{
			return 0f;
		}

		// Token: 0x06000233 RID: 563 RVA: 0x00002E7C File Offset: 0x0000107C
		[Token(Token = "0x6000233")]
		[Address(RVA = "0x4E4C120", Offset = "0x4E4AD20", VA = "0x184E4C120")]
		public float LocalToWorldRotation(float localRotation)
		{
			return 0f;
		}

		// Token: 0x06000234 RID: 564 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000234")]
		[Address(RVA = "0x4E4C2D0", Offset = "0x4E4AED0", VA = "0x184E4C2D0")]
		public void RotateWorld(float degrees)
		{
		}

		// Token: 0x06000235 RID: 565 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000235")]
		[Address(RVA = "0x5B5460", Offset = "0x5B4060", VA = "0x1805B5460", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x04000174 RID: 372
		[Token(Token = "0x4000174")]
		[FieldOffset(Offset = "0x0")]
		public static bool yDown;

		// Token: 0x04000175 RID: 373
		[Token(Token = "0x4000175")]
		[FieldOffset(Offset = "0x10")]
		internal BoneData data;

		// Token: 0x04000176 RID: 374
		[Token(Token = "0x4000176")]
		[FieldOffset(Offset = "0x18")]
		internal Skeleton skeleton;

		// Token: 0x04000177 RID: 375
		[Token(Token = "0x4000177")]
		[FieldOffset(Offset = "0x20")]
		internal Bone parent;

		// Token: 0x04000178 RID: 376
		[Token(Token = "0x4000178")]
		[FieldOffset(Offset = "0x28")]
		internal ExposedList<Bone> children;

		// Token: 0x04000179 RID: 377
		[Token(Token = "0x4000179")]
		[FieldOffset(Offset = "0x30")]
		internal float x;

		// Token: 0x0400017A RID: 378
		[Token(Token = "0x400017A")]
		[FieldOffset(Offset = "0x34")]
		internal float y;

		// Token: 0x0400017B RID: 379
		[Token(Token = "0x400017B")]
		[FieldOffset(Offset = "0x38")]
		internal float rotation;

		// Token: 0x0400017C RID: 380
		[Token(Token = "0x400017C")]
		[FieldOffset(Offset = "0x3C")]
		internal float scaleX;

		// Token: 0x0400017D RID: 381
		[Token(Token = "0x400017D")]
		[FieldOffset(Offset = "0x40")]
		internal float scaleY;

		// Token: 0x0400017E RID: 382
		[Token(Token = "0x400017E")]
		[FieldOffset(Offset = "0x44")]
		internal float shearX;

		// Token: 0x0400017F RID: 383
		[Token(Token = "0x400017F")]
		[FieldOffset(Offset = "0x48")]
		internal float shearY;

		// Token: 0x04000180 RID: 384
		[Token(Token = "0x4000180")]
		[FieldOffset(Offset = "0x4C")]
		internal float ax;

		// Token: 0x04000181 RID: 385
		[Token(Token = "0x4000181")]
		[FieldOffset(Offset = "0x50")]
		internal float ay;

		// Token: 0x04000182 RID: 386
		[Token(Token = "0x4000182")]
		[FieldOffset(Offset = "0x54")]
		internal float arotation;

		// Token: 0x04000183 RID: 387
		[Token(Token = "0x4000183")]
		[FieldOffset(Offset = "0x58")]
		internal float ascaleX;

		// Token: 0x04000184 RID: 388
		[Token(Token = "0x4000184")]
		[FieldOffset(Offset = "0x5C")]
		internal float ascaleY;

		// Token: 0x04000185 RID: 389
		[Token(Token = "0x4000185")]
		[FieldOffset(Offset = "0x60")]
		internal float ashearX;

		// Token: 0x04000186 RID: 390
		[Token(Token = "0x4000186")]
		[FieldOffset(Offset = "0x64")]
		internal float ashearY;

		// Token: 0x04000187 RID: 391
		[Token(Token = "0x4000187")]
		[FieldOffset(Offset = "0x68")]
		internal bool appliedValid;

		// Token: 0x04000188 RID: 392
		[Token(Token = "0x4000188")]
		[FieldOffset(Offset = "0x6C")]
		internal float a;

		// Token: 0x04000189 RID: 393
		[Token(Token = "0x4000189")]
		[FieldOffset(Offset = "0x70")]
		internal float b;

		// Token: 0x0400018A RID: 394
		[Token(Token = "0x400018A")]
		[FieldOffset(Offset = "0x74")]
		internal float worldX;

		// Token: 0x0400018B RID: 395
		[Token(Token = "0x400018B")]
		[FieldOffset(Offset = "0x78")]
		internal float c;

		// Token: 0x0400018C RID: 396
		[Token(Token = "0x400018C")]
		[FieldOffset(Offset = "0x7C")]
		internal float d;

		// Token: 0x0400018D RID: 397
		[Token(Token = "0x400018D")]
		[FieldOffset(Offset = "0x80")]
		internal float worldY;

		// Token: 0x0400018E RID: 398
		[Token(Token = "0x400018E")]
		[FieldOffset(Offset = "0x84")]
		internal bool sorted;

		// Token: 0x0400018F RID: 399
		[Token(Token = "0x400018F")]
		[FieldOffset(Offset = "0x85")]
		internal bool active;
	}
}
