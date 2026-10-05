using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Rendering;

namespace UnityEngine
{
	// Token: 0x02000091 RID: 145
	[Token(Token = "0x2000091")]
	[RequireComponent(typeof(Transform))]
	[NativeHeader("Runtime/Camera/Light.h")]
	[NativeHeader("Runtime/Export/Graphics/Light.bindings.h")]
	[RequireComponent(typeof(Transform))]
	public sealed class Light : Behaviour
	{
		// Token: 0x1700010C RID: 268
		// (get) Token: 0x0600047F RID: 1151
		// (set) Token: 0x06000480 RID: 1152
		[Token(Token = "0x1700010C")]
		[NativeProperty("LightType")]
		public extern LightType type { [Token(Token = "0x600047F")] [Address(RVA = "0x592DBF0", Offset = "0x592C7F0", VA = "0x18592DBF0")] [MethodImpl(4096)] get; [Token(Token = "0x6000480")] [Address(RVA = "0x592E650", Offset = "0x592D250", VA = "0x18592E650")] [MethodImpl(4096)] set; }

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x06000481 RID: 1153
		// (set) Token: 0x06000482 RID: 1154
		[Token(Token = "0x1700010D")]
		[NativeProperty("LightShape")]
		public extern LightShape shape { [Token(Token = "0x6000481")] [Address(RVA = "0x592DB70", Offset = "0x592C770", VA = "0x18592DB70")] [MethodImpl(4096)] get; [Token(Token = "0x6000482")] [Address(RVA = "0x592E5C0", Offset = "0x592D1C0", VA = "0x18592E5C0")] [MethodImpl(4096)] set; }

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x06000483 RID: 1155
		// (set) Token: 0x06000484 RID: 1156
		[Token(Token = "0x1700010E")]
		public extern float spotAngle { [Token(Token = "0x6000483")] [Address(RVA = "0x592DBB0", Offset = "0x592C7B0", VA = "0x18592DBB0")] [MethodImpl(4096)] get; [Token(Token = "0x6000484")] [Address(RVA = "0x592E600", Offset = "0x592D200", VA = "0x18592E600")] [MethodImpl(4096)] set; }

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x06000485 RID: 1157
		// (set) Token: 0x06000486 RID: 1158
		[Token(Token = "0x1700010F")]
		public extern float innerSpotAngle { [Token(Token = "0x6000485")] [Address(RVA = "0x592D6E0", Offset = "0x592C2E0", VA = "0x18592D6E0")] [MethodImpl(4096)] get; [Token(Token = "0x6000486")] [Address(RVA = "0x592E0E0", Offset = "0x592CCE0", VA = "0x18592E0E0")] [MethodImpl(4096)] set; }

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x06000487 RID: 1159 RVA: 0x00003360 File Offset: 0x00001560
		// (set) Token: 0x06000488 RID: 1160 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000110")]
		public Color color
		{
			[Token(Token = "0x6000487")]
			[Address(RVA = "0x592D550", Offset = "0x592C150", VA = "0x18592D550")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000488")]
			[Address(RVA = "0x592DF60", Offset = "0x592CB60", VA = "0x18592DF60")]
			set
			{
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x06000489 RID: 1161
		// (set) Token: 0x0600048A RID: 1162
		[Token(Token = "0x17000111")]
		public extern float colorTemperature { [Token(Token = "0x6000489")] [Address(RVA = "0x592D4C0", Offset = "0x592C0C0", VA = "0x18592D4C0")] [MethodImpl(4096)] get; [Token(Token = "0x600048A")] [Address(RVA = "0x592DEC0", Offset = "0x592CAC0", VA = "0x18592DEC0")] [MethodImpl(4096)] set; }

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x0600048B RID: 1163
		// (set) Token: 0x0600048C RID: 1164
		[Token(Token = "0x17000112")]
		public extern bool useColorTemperature { [Token(Token = "0x600048B")] [Address(RVA = "0x592DC70", Offset = "0x592C870", VA = "0x18592DC70")] [MethodImpl(4096)] get; [Token(Token = "0x600048C")] [Address(RVA = "0x592E6E0", Offset = "0x592D2E0", VA = "0x18592E6E0")] [MethodImpl(4096)] set; }

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x0600048D RID: 1165
		// (set) Token: 0x0600048E RID: 1166
		[Token(Token = "0x17000113")]
		public extern float intensity { [Token(Token = "0x600048D")] [Address(RVA = "0x592D720", Offset = "0x592C320", VA = "0x18592D720")] [MethodImpl(4096)] get; [Token(Token = "0x600048E")] [Address(RVA = "0x592E130", Offset = "0x592CD30", VA = "0x18592E130")] [MethodImpl(4096)] set; }

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x0600048F RID: 1167
		// (set) Token: 0x06000490 RID: 1168
		[Token(Token = "0x17000114")]
		public extern float bounceIntensity { [Token(Token = "0x600048F")] [Address(RVA = "0x592D3E0", Offset = "0x592BFE0", VA = "0x18592D3E0")] [MethodImpl(4096)] get; [Token(Token = "0x6000490")] [Address(RVA = "0x592DDD0", Offset = "0x592C9D0", VA = "0x18592DDD0")] [MethodImpl(4096)] set; }

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x06000491 RID: 1169
		// (set) Token: 0x06000492 RID: 1170
		[Token(Token = "0x17000115")]
		public extern bool useBoundingSphereOverride { [Token(Token = "0x6000491")] [Address(RVA = "0x592DC30", Offset = "0x592C830", VA = "0x18592DC30")] [MethodImpl(4096)] get; [Token(Token = "0x6000492")] [Address(RVA = "0x592E690", Offset = "0x592D290", VA = "0x18592E690")] [MethodImpl(4096)] set; }

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x06000493 RID: 1171 RVA: 0x00003378 File Offset: 0x00001578
		// (set) Token: 0x06000494 RID: 1172 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000116")]
		public Vector4 boundingSphereOverride
		{
			[Token(Token = "0x6000493")]
			[Address(RVA = "0x592D470", Offset = "0x592C070", VA = "0x18592D470")]
			get
			{
				return default(Vector4);
			}
			[Token(Token = "0x6000494")]
			[Address(RVA = "0x592DE70", Offset = "0x592CA70", VA = "0x18592DE70")]
			set
			{
			}
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x06000495 RID: 1173
		// (set) Token: 0x06000496 RID: 1174
		[Token(Token = "0x17000117")]
		public extern bool useViewFrustumForShadowCasterCull { [Token(Token = "0x6000495")] [Address(RVA = "0x592DCF0", Offset = "0x592C8F0", VA = "0x18592DCF0")] [MethodImpl(4096)] get; [Token(Token = "0x6000496")] [Address(RVA = "0x592E780", Offset = "0x592D380", VA = "0x18592E780")] [MethodImpl(4096)] set; }

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x06000497 RID: 1175
		// (set) Token: 0x06000498 RID: 1176
		[Token(Token = "0x17000118")]
		public extern int shadowCustomResolution { [Token(Token = "0x6000497")] [Address(RVA = "0x592D920", Offset = "0x592C520", VA = "0x18592D920")] [MethodImpl(4096)] get; [Token(Token = "0x6000498")] [Address(RVA = "0x592E370", Offset = "0x592CF70", VA = "0x18592E370")] [MethodImpl(4096)] set; }

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x06000499 RID: 1177
		// (set) Token: 0x0600049A RID: 1178
		[Token(Token = "0x17000119")]
		public extern float shadowBias { [Token(Token = "0x6000499")] [Address(RVA = "0x592D8D0", Offset = "0x592C4D0", VA = "0x18592D8D0")] [MethodImpl(4096)] get; [Token(Token = "0x600049A")] [Address(RVA = "0x592E320", Offset = "0x592CF20", VA = "0x18592E320")] [MethodImpl(4096)] set; }

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x0600049B RID: 1179
		// (set) Token: 0x0600049C RID: 1180
		[Token(Token = "0x1700011A")]
		public extern float shadowNormalBias { [Token(Token = "0x600049B")] [Address(RVA = "0x592DA50", Offset = "0x592C650", VA = "0x18592DA50")] [MethodImpl(4096)] get; [Token(Token = "0x600049C")] [Address(RVA = "0x592E4A0", Offset = "0x592D0A0", VA = "0x18592E4A0")] [MethodImpl(4096)] set; }

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x0600049D RID: 1181
		// (set) Token: 0x0600049E RID: 1182
		[Token(Token = "0x1700011B")]
		public extern float shadowNearPlane { [Token(Token = "0x600049D")] [Address(RVA = "0x592DA10", Offset = "0x592C610", VA = "0x18592DA10")] [MethodImpl(4096)] get; [Token(Token = "0x600049E")] [Address(RVA = "0x592E450", Offset = "0x592D050", VA = "0x18592E450")] [MethodImpl(4096)] set; }

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x0600049F RID: 1183
		// (set) Token: 0x060004A0 RID: 1184
		[Token(Token = "0x1700011C")]
		public extern bool useShadowMatrixOverride { [Token(Token = "0x600049F")] [Address(RVA = "0x592DCB0", Offset = "0x592C8B0", VA = "0x18592DCB0")] [MethodImpl(4096)] get; [Token(Token = "0x60004A0")] [Address(RVA = "0x592E730", Offset = "0x592D330", VA = "0x18592E730")] [MethodImpl(4096)] set; }

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x060004A1 RID: 1185 RVA: 0x00003390 File Offset: 0x00001590
		// (set) Token: 0x060004A2 RID: 1186 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700011D")]
		public Matrix4x4 shadowMatrixOverride
		{
			[Token(Token = "0x60004A1")]
			[Address(RVA = "0x592D9B0", Offset = "0x592C5B0", VA = "0x18592D9B0")]
			get
			{
				return default(Matrix4x4);
			}
			[Token(Token = "0x60004A2")]
			[Address(RVA = "0x592E400", Offset = "0x592D000", VA = "0x18592E400")]
			set
			{
			}
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x060004A3 RID: 1187
		// (set) Token: 0x060004A4 RID: 1188
		[Token(Token = "0x1700011E")]
		public extern float range { [Token(Token = "0x60004A3")] [Address(RVA = "0x592D810", Offset = "0x592C410", VA = "0x18592D810")] [MethodImpl(4096)] get; [Token(Token = "0x60004A4")] [Address(RVA = "0x592E250", Offset = "0x592CE50", VA = "0x18592E250")] [MethodImpl(4096)] set; }

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x060004A5 RID: 1189
		// (set) Token: 0x060004A6 RID: 1190
		[Token(Token = "0x1700011F")]
		public extern Flare flare { [Token(Token = "0x60004A5")] [Address(RVA = "0x592D6A0", Offset = "0x592C2A0", VA = "0x18592D6A0")] [MethodImpl(4096)] get; [Token(Token = "0x60004A6")] [Address(RVA = "0x592E090", Offset = "0x592CC90", VA = "0x18592E090")] [MethodImpl(4096)] set; }

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x060004A7 RID: 1191 RVA: 0x000033A8 File Offset: 0x000015A8
		// (set) Token: 0x060004A8 RID: 1192 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000120")]
		public LightBakingOutput bakingOutput
		{
			[Token(Token = "0x60004A7")]
			[Address(RVA = "0x592D390", Offset = "0x592BF90", VA = "0x18592D390")]
			get
			{
				return default(LightBakingOutput);
			}
			[Token(Token = "0x60004A8")]
			[Address(RVA = "0x592DD80", Offset = "0x592C980", VA = "0x18592DD80")]
			set
			{
			}
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x060004A9 RID: 1193
		// (set) Token: 0x060004AA RID: 1194
		[Token(Token = "0x17000121")]
		public extern int cullingMask { [Token(Token = "0x60004A9")] [Address(RVA = "0x592D660", Offset = "0x592C260", VA = "0x18592D660")] [MethodImpl(4096)] get; [Token(Token = "0x60004AA")] [Address(RVA = "0x592E050", Offset = "0x592CC50", VA = "0x18592E050")] [MethodImpl(4096)] set; }

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x060004AB RID: 1195
		// (set) Token: 0x060004AC RID: 1196
		[Token(Token = "0x17000122")]
		public extern int renderingLayerMask { [Token(Token = "0x60004AB")] [Address(RVA = "0x592D890", Offset = "0x592C490", VA = "0x18592D890")] [MethodImpl(4096)] get; [Token(Token = "0x60004AC")] [Address(RVA = "0x592E2E0", Offset = "0x592CEE0", VA = "0x18592E2E0")] [MethodImpl(4096)] set; }

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x060004AD RID: 1197
		// (set) Token: 0x060004AE RID: 1198
		[Token(Token = "0x17000123")]
		public extern LightShadowCasterMode lightShadowCasterMode { [Token(Token = "0x60004AD")] [Address(RVA = "0x592D7A0", Offset = "0x592C3A0", VA = "0x18592D7A0")] [MethodImpl(4096)] get; [Token(Token = "0x60004AE")] [Address(RVA = "0x592E1D0", Offset = "0x592CDD0", VA = "0x18592E1D0")] [MethodImpl(4096)] set; }

		// Token: 0x060004AF RID: 1199
		[Token(Token = "0x60004AF")]
		[Address(RVA = "0x592D300", Offset = "0x592BF00", VA = "0x18592D300")]
		[MethodImpl(4096)]
		public extern void Reset();

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x060004B0 RID: 1200
		// (set) Token: 0x060004B1 RID: 1201
		[Token(Token = "0x17000124")]
		public extern LightShadows shadows { [Token(Token = "0x60004B0")] [Address(RVA = "0x592DB30", Offset = "0x592C730", VA = "0x18592DB30")] [NativeMethod("GetShadowType")] [MethodImpl(4096)] get; [Token(Token = "0x60004B1")] [Address(RVA = "0x592E580", Offset = "0x592D180", VA = "0x18592E580")] [FreeFunction("Light_Bindings::SetShadowType", HasExplicitThis = true, ThrowsException = true)] [MethodImpl(4096)] set; }

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x060004B2 RID: 1202
		// (set) Token: 0x060004B3 RID: 1203
		[Token(Token = "0x17000125")]
		public extern float shadowStrength { [Token(Token = "0x60004B2")] [Address(RVA = "0x592DAF0", Offset = "0x592C6F0", VA = "0x18592DAF0")] [MethodImpl(4096)] get; [Token(Token = "0x60004B3")] [Address(RVA = "0x592E530", Offset = "0x592D130", VA = "0x18592E530")] [FreeFunction("Light_Bindings::SetShadowStrength", HasExplicitThis = true)] [MethodImpl(4096)] set; }

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x060004B4 RID: 1204
		// (set) Token: 0x060004B5 RID: 1205
		[Token(Token = "0x17000126")]
		public extern LightShadowResolution shadowResolution { [Token(Token = "0x60004B4")] [Address(RVA = "0x592DA90", Offset = "0x592C690", VA = "0x18592DA90")] [MethodImpl(4096)] get; [Token(Token = "0x60004B5")] [Address(RVA = "0x592E4F0", Offset = "0x592D0F0", VA = "0x18592E4F0")] [FreeFunction("Light_Bindings::SetShadowResolution", HasExplicitThis = true, ThrowsException = true)] [MethodImpl(4096)] set; }

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x060004B6 RID: 1206 RVA: 0x000033C0 File Offset: 0x000015C0
		// (set) Token: 0x060004B7 RID: 1207 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000127")]
		[Obsolete("Shadow softness is removed in Unity 5.0+", true)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public float shadowSoftness
		{
			[Token(Token = "0x60004B6")]
			[Address(RVA = "0x592DAE0", Offset = "0x592C6E0", VA = "0x18592DAE0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60004B7")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
			set
			{
			}
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x060004B8 RID: 1208 RVA: 0x000033D8 File Offset: 0x000015D8
		// (set) Token: 0x060004B9 RID: 1209 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000128")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Shadow softness is removed in Unity 5.0+", true)]
		public float shadowSoftnessFade
		{
			[Token(Token = "0x60004B8")]
			[Address(RVA = "0x592DAD0", Offset = "0x592C6D0", VA = "0x18592DAD0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60004B9")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
			set
			{
			}
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x060004BA RID: 1210
		// (set) Token: 0x060004BB RID: 1211
		[Token(Token = "0x17000129")]
		public extern float[] layerShadowCullDistances { [Token(Token = "0x60004BA")] [Address(RVA = "0x592D760", Offset = "0x592C360", VA = "0x18592D760")] [FreeFunction("Light_Bindings::GetLayerShadowCullDistances", HasExplicitThis = true, ThrowsException = false)] [MethodImpl(4096)] get; [Token(Token = "0x60004BB")] [Address(RVA = "0x592E180", Offset = "0x592CD80", VA = "0x18592E180")] [FreeFunction("Light_Bindings::SetLayerShadowCullDistances", HasExplicitThis = true, ThrowsException = true)] [MethodImpl(4096)] set; }

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x060004BC RID: 1212
		// (set) Token: 0x060004BD RID: 1213
		[Token(Token = "0x1700012A")]
		public extern float cookieSize { [Token(Token = "0x60004BC")] [Address(RVA = "0x592D5E0", Offset = "0x592C1E0", VA = "0x18592D5E0")] [MethodImpl(4096)] get; [Token(Token = "0x60004BD")] [Address(RVA = "0x592DFB0", Offset = "0x592CBB0", VA = "0x18592DFB0")] [MethodImpl(4096)] set; }

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x060004BE RID: 1214
		// (set) Token: 0x060004BF RID: 1215
		[Token(Token = "0x1700012B")]
		public extern Texture cookie { [Token(Token = "0x60004BE")] [Address(RVA = "0x592D620", Offset = "0x592C220", VA = "0x18592D620")] [MethodImpl(4096)] get; [Token(Token = "0x60004BF")] [Address(RVA = "0x592E000", Offset = "0x592CC00", VA = "0x18592E000")] [MethodImpl(4096)] set; }

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x060004C0 RID: 1216
		// (set) Token: 0x060004C1 RID: 1217
		[Token(Token = "0x1700012C")]
		public extern LightRenderMode renderMode { [Token(Token = "0x60004C0")] [Address(RVA = "0x592D850", Offset = "0x592C450", VA = "0x18592D850")] [MethodImpl(4096)] get; [Token(Token = "0x60004C1")] [Address(RVA = "0x592E2A0", Offset = "0x592CEA0", VA = "0x18592E2A0")] [FreeFunction("Light_Bindings::SetRenderMode", HasExplicitThis = true, ThrowsException = true)] [MethodImpl(4096)] set; }

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x060004C2 RID: 1218 RVA: 0x000033F0 File Offset: 0x000015F0
		// (set) Token: 0x060004C3 RID: 1219 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700012D")]
		[Obsolete("warning bakedIndex has been removed please use bakingOutput.isBaked instead.", true)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int bakedIndex
		{
			[Token(Token = "0x60004C2")]
			[Address(RVA = "0x428FB90", Offset = "0x428E790", VA = "0x18428FB90")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60004C3")]
			[Address(RVA = "0x4EA9A0", Offset = "0x4E95A0", VA = "0x1804EA9A0")]
			set
			{
			}
		}

		// Token: 0x060004C4 RID: 1220 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x592D150", Offset = "0x592BD50", VA = "0x18592D150")]
		public void AddCommandBuffer(LightEvent evt, CommandBuffer buffer)
		{
		}

		// Token: 0x060004C5 RID: 1221
		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x592D0F0", Offset = "0x592BCF0", VA = "0x18592D0F0")]
		[FreeFunction("Light_Bindings::AddCommandBuffer", HasExplicitThis = true)]
		[MethodImpl(4096)]
		public extern void AddCommandBuffer(LightEvent evt, CommandBuffer buffer, ShadowMapPass shadowPassMask);

		// Token: 0x060004C6 RID: 1222 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x592D020", Offset = "0x592BC20", VA = "0x18592D020")]
		public void AddCommandBufferAsync(LightEvent evt, CommandBuffer buffer, ComputeQueueType queueType)
		{
		}

		// Token: 0x060004C7 RID: 1223
		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x592D090", Offset = "0x592BC90", VA = "0x18592D090")]
		[FreeFunction("Light_Bindings::AddCommandBufferAsync", HasExplicitThis = true)]
		[MethodImpl(4096)]
		public extern void AddCommandBufferAsync(LightEvent evt, CommandBuffer buffer, ShadowMapPass shadowPassMask, ComputeQueueType queueType);

		// Token: 0x060004C8 RID: 1224
		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x592D270", Offset = "0x592BE70", VA = "0x18592D270")]
		[MethodImpl(4096)]
		public extern void RemoveCommandBuffer(LightEvent evt, CommandBuffer buffer);

		// Token: 0x060004C9 RID: 1225
		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x592D2C0", Offset = "0x592BEC0", VA = "0x18592D2C0")]
		[MethodImpl(4096)]
		public extern void RemoveCommandBuffers(LightEvent evt);

		// Token: 0x060004CA RID: 1226
		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x592D230", Offset = "0x592BE30", VA = "0x18592D230")]
		[MethodImpl(4096)]
		public extern void RemoveAllCommandBuffers();

		// Token: 0x060004CB RID: 1227
		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x592D1B0", Offset = "0x592BDB0", VA = "0x18592D1B0")]
		[FreeFunction("Light_Bindings::GetCommandBuffers", HasExplicitThis = true)]
		[MethodImpl(4096)]
		public extern CommandBuffer[] GetCommandBuffers(LightEvent evt);

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x060004CC RID: 1228
		[Token(Token = "0x1700012E")]
		public extern int commandBufferCount { [Token(Token = "0x60004CC")] [Address(RVA = "0x592D5A0", Offset = "0x592C1A0", VA = "0x18592D5A0")] [MethodImpl(4096)] get; }

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x060004CD RID: 1229 RVA: 0x00003408 File Offset: 0x00001608
		// (set) Token: 0x060004CE RID: 1230 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700012F")]
		[Obsolete("Use QualitySettings.pixelLightCount instead.")]
		public static int pixelLightCount
		{
			[Token(Token = "0x60004CD")]
			[Address(RVA = "0x592D7E0", Offset = "0x592C3E0", VA = "0x18592D7E0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x60004CE")]
			[Address(RVA = "0x592E210", Offset = "0x592CE10", VA = "0x18592E210")]
			set
			{
			}
		}

		// Token: 0x060004CF RID: 1231
		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x592D1F0", Offset = "0x592BDF0", VA = "0x18592D1F0")]
		[FreeFunction("Light_Bindings::GetLights")]
		[MethodImpl(4096)]
		public static extern Light[] GetLights(LightType type, int layer);

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x060004D0 RID: 1232 RVA: 0x00003420 File Offset: 0x00001620
		// (set) Token: 0x060004D1 RID: 1233 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000130")]
		[Obsolete("light.shadowConstantBias was removed, use light.shadowBias", true)]
		public float shadowConstantBias
		{
			[Token(Token = "0x60004D0")]
			[Address(RVA = "0x592D910", Offset = "0x592C510", VA = "0x18592D910")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60004D1")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
			set
			{
			}
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x060004D2 RID: 1234 RVA: 0x00003438 File Offset: 0x00001638
		// (set) Token: 0x060004D3 RID: 1235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000131")]
		[Obsolete("light.shadowObjectSizeBias was removed, use light.shadowBias", true)]
		public float shadowObjectSizeBias
		{
			[Token(Token = "0x60004D2")]
			[Address(RVA = "0x592D910", Offset = "0x592C510", VA = "0x18592D910")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60004D3")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
			set
			{
			}
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x060004D4 RID: 1236 RVA: 0x00003450 File Offset: 0x00001650
		// (set) Token: 0x060004D5 RID: 1237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000132")]
		[Obsolete("light.attenuate was removed; all lights always attenuate now", true)]
		public bool attenuate
		{
			[Token(Token = "0x60004D4")]
			[Address(RVA = "0x3E67470", Offset = "0x3E66070", VA = "0x183E67470")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004D5")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
			set
			{
			}
		}

		// Token: 0x060004D6 RID: 1238 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004D6")]
		[Address(RVA = "0x59165F0", Offset = "0x59151F0", VA = "0x1859165F0")]
		public Light()
		{
		}

		// Token: 0x060004D7 RID: 1239
		[Token(Token = "0x60004D7")]
		[Address(RVA = "0x592D500", Offset = "0x592C100", VA = "0x18592D500")]
		[MethodImpl(4096)]
		private extern void get_color_Injected(out Color ret);

		// Token: 0x060004D8 RID: 1240
		[Token(Token = "0x60004D8")]
		[Address(RVA = "0x592DF10", Offset = "0x592CB10", VA = "0x18592DF10")]
		[MethodImpl(4096)]
		private extern void set_color_Injected(ref Color value);

		// Token: 0x060004D9 RID: 1241
		[Token(Token = "0x60004D9")]
		[Address(RVA = "0x592D420", Offset = "0x592C020", VA = "0x18592D420")]
		[MethodImpl(4096)]
		private extern void get_boundingSphereOverride_Injected(out Vector4 ret);

		// Token: 0x060004DA RID: 1242
		[Token(Token = "0x60004DA")]
		[Address(RVA = "0x592DE20", Offset = "0x592CA20", VA = "0x18592DE20")]
		[MethodImpl(4096)]
		private extern void set_boundingSphereOverride_Injected(ref Vector4 value);

		// Token: 0x060004DB RID: 1243
		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x592D960", Offset = "0x592C560", VA = "0x18592D960")]
		[MethodImpl(4096)]
		private extern void get_shadowMatrixOverride_Injected(out Matrix4x4 ret);

		// Token: 0x060004DC RID: 1244
		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x592E3B0", Offset = "0x592CFB0", VA = "0x18592E3B0")]
		[MethodImpl(4096)]
		private extern void set_shadowMatrixOverride_Injected(ref Matrix4x4 value);

		// Token: 0x060004DD RID: 1245
		[Token(Token = "0x60004DD")]
		[Address(RVA = "0x592D340", Offset = "0x592BF40", VA = "0x18592D340")]
		[MethodImpl(4096)]
		private extern void get_bakingOutput_Injected(out LightBakingOutput ret);

		// Token: 0x060004DE RID: 1246
		[Token(Token = "0x60004DE")]
		[Address(RVA = "0x592DD30", Offset = "0x592C930", VA = "0x18592DD30")]
		[MethodImpl(4096)]
		private extern void set_bakingOutput_Injected(ref LightBakingOutput value);

		// Token: 0x040001A5 RID: 421
		[Token(Token = "0x40001A5")]
		[FieldOffset(Offset = "0x18")]
		private int m_BakedIndex;
	}
}
