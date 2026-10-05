using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Rendering;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x0200008B RID: 139
	[Token(Token = "0x200008B")]
	[NativeHeader("Runtime/Graphics/ShaderScriptBindings.h")]
	[NativeHeader("Runtime/Shaders/Material.h")]
	public class Material : Object
	{
		// Token: 0x0600042C RID: 1068
		[Token(Token = "0x600042C")]
		[Address(RVA = "0x592FC20", Offset = "0x592E820", VA = "0x18592FC20")]
		[FreeFunction("MaterialScripting::CreateWithShader")]
		[MethodImpl(4096)]
		private static extern void CreateWithShader([Writable] Material self, [NotNull("ArgumentNullException")] Shader shader);

		// Token: 0x0600042D RID: 1069
		[Token(Token = "0x600042D")]
		[Address(RVA = "0x592FBD0", Offset = "0x592E7D0", VA = "0x18592FBD0")]
		[FreeFunction("MaterialScripting::CreateWithMaterial")]
		[MethodImpl(4096)]
		private static extern void CreateWithMaterial([Writable] Material self, [NotNull("ArgumentNullException")] Material source);

		// Token: 0x0600042E RID: 1070
		[Token(Token = "0x600042E")]
		[Address(RVA = "0x592FC70", Offset = "0x592E870", VA = "0x18592FC70")]
		[FreeFunction("MaterialScripting::CreateWithString")]
		[MethodImpl(4096)]
		private static extern void CreateWithString([Writable] Material self);

		// Token: 0x0600042F RID: 1071 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600042F")]
		[Address(RVA = "0x5931170", Offset = "0x592FD70", VA = "0x185931170")]
		public Material(Shader shader)
		{
		}

		// Token: 0x06000430 RID: 1072 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000430")]
		[Address(RVA = "0x5931260", Offset = "0x592FE60", VA = "0x185931260")]
		[RequiredByNativeCode]
		public Material(Material source)
		{
		}

		// Token: 0x06000431 RID: 1073 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000431")]
		[Address(RVA = "0x59311F0", Offset = "0x592FDF0", VA = "0x1859311F0")]
		[Obsolete("Creating materials from shader source string is no longer supported. Use Shader assets instead.", false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public Material(string contents)
		{
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x06000432 RID: 1074
		// (set) Token: 0x06000433 RID: 1075
		[Token(Token = "0x17000103")]
		public extern Shader shader { [Token(Token = "0x6000432")] [Address(RVA = "0x5931770", Offset = "0x5930370", VA = "0x185931770")] [MethodImpl(4096)] get; [Token(Token = "0x6000433")] [Address(RVA = "0x5931BB0", Offset = "0x59307B0", VA = "0x185931BB0")] [MethodImpl(4096)] set; }

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x06000434 RID: 1076 RVA: 0x000031E0 File Offset: 0x000013E0
		// (set) Token: 0x06000435 RID: 1077 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000104")]
		public Color color
		{
			[Token(Token = "0x6000434")]
			[Address(RVA = "0x59312E0", Offset = "0x592FEE0", VA = "0x1859312E0")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000435")]
			[Address(RVA = "0x59317B0", Offset = "0x59303B0", VA = "0x1859317B0")]
			set
			{
			}
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x06000436 RID: 1078 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000437 RID: 1079 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000105")]
		public Texture mainTexture
		{
			[Token(Token = "0x6000436")]
			[Address(RVA = "0x5931630", Offset = "0x5930230", VA = "0x185931630")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000437")]
			[Address(RVA = "0x5931AA0", Offset = "0x59306A0", VA = "0x185931AA0")]
			set
			{
			}
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x06000438 RID: 1080 RVA: 0x000031F8 File Offset: 0x000013F8
		// (set) Token: 0x06000439 RID: 1081 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000106")]
		public Vector2 mainTextureOffset
		{
			[Token(Token = "0x6000438")]
			[Address(RVA = "0x59313D0", Offset = "0x592FFD0", VA = "0x1859313D0")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6000439")]
			[Address(RVA = "0x59318E0", Offset = "0x59304E0", VA = "0x1859318E0")]
			set
			{
			}
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x0600043A RID: 1082 RVA: 0x00003210 File Offset: 0x00001410
		// (set) Token: 0x0600043B RID: 1083 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000107")]
		public Vector2 mainTextureScale
		{
			[Token(Token = "0x600043A")]
			[Address(RVA = "0x5931500", Offset = "0x5930100", VA = "0x185931500")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x600043B")]
			[Address(RVA = "0x59319C0", Offset = "0x59305C0", VA = "0x1859319C0")]
			set
			{
			}
		}

		// Token: 0x0600043C RID: 1084
		[Token(Token = "0x600043C")]
		[Address(RVA = "0x592FF10", Offset = "0x592EB10", VA = "0x18592FF10")]
		[NativeName("GetFirstPropertyNameIdByAttributeFromScript")]
		[MethodImpl(4096)]
		private extern int GetFirstPropertyNameIdByAttribute(ShaderPropertyFlags attributeFlag);

		// Token: 0x0600043D RID: 1085
		[Token(Token = "0x600043D")]
		[Address(RVA = "0x59305B0", Offset = "0x592F1B0", VA = "0x1859305B0")]
		[NativeName("HasPropertyFromScript")]
		[MethodImpl(4096)]
		public extern bool HasProperty(int nameID);

		// Token: 0x0600043E RID: 1086 RVA: 0x00003228 File Offset: 0x00001428
		[Token(Token = "0x600043E")]
		[Address(RVA = "0x59305F0", Offset = "0x592F1F0", VA = "0x1859305F0")]
		public bool HasProperty(string name)
		{
			return default(bool);
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x0600043F RID: 1087
		// (set) Token: 0x06000440 RID: 1088
		[Token(Token = "0x17000108")]
		public extern int renderQueue { [Token(Token = "0x600043F")] [Address(RVA = "0x5931730", Offset = "0x5930330", VA = "0x185931730")] [NativeName("GetActualRenderQueue")] [MethodImpl(4096)] get; [Token(Token = "0x6000440")] [Address(RVA = "0x5931B70", Offset = "0x5930770", VA = "0x185931B70")] [NativeName("SetCustomRenderQueue")] [MethodImpl(4096)] set; }

		// Token: 0x06000441 RID: 1089
		[Token(Token = "0x6000441")]
		[Address(RVA = "0x592FD00", Offset = "0x592E900", VA = "0x18592FD00")]
		[MethodImpl(4096)]
		public extern void EnableKeyword(string keyword);

		// Token: 0x06000442 RID: 1090
		[Token(Token = "0x6000442")]
		[Address(RVA = "0x592FCB0", Offset = "0x592E8B0", VA = "0x18592FCB0")]
		[MethodImpl(4096)]
		public extern void DisableKeyword(string keyword);

		// Token: 0x06000443 RID: 1091
		[Token(Token = "0x6000443")]
		[Address(RVA = "0x5930660", Offset = "0x592F260", VA = "0x185930660")]
		[MethodImpl(4096)]
		public extern bool IsKeywordEnabled(string keyword);

		// Token: 0x17000109 RID: 265
		// (set) Token: 0x06000444 RID: 1092
		[Token(Token = "0x17000109")]
		[NativeProperty("EnableInstancingVariants")]
		public extern bool enableInstancing { [Token(Token = "0x6000444")] [Address(RVA = "0x5931890", Offset = "0x5930490", VA = "0x185931890")] [MethodImpl(4096)] set; }

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x06000445 RID: 1093
		[Token(Token = "0x1700010A")]
		public extern int passCount { [Token(Token = "0x6000445")] [Address(RVA = "0x59316F0", Offset = "0x59302F0", VA = "0x1859316F0")] [NativeName("GetShader()->GetPassCount")] [MethodImpl(4096)] get; }

		// Token: 0x06000446 RID: 1094
		[Token(Token = "0x6000446")]
		[Address(RVA = "0x5930040", Offset = "0x592EC40", VA = "0x185930040")]
		[NativeName("GetTag")]
		[MethodImpl(4096)]
		private extern string GetTagImpl(string tag, bool currentSubShaderOnly, string defaultValue);

		// Token: 0x06000447 RID: 1095 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000447")]
		[Address(RVA = "0x59300B0", Offset = "0x592ECB0", VA = "0x1859300B0")]
		public string GetTag(string tag, bool searchFallbacks)
		{
			return null;
		}

		// Token: 0x06000448 RID: 1096
		[Token(Token = "0x6000448")]
		[Address(RVA = "0x5930C60", Offset = "0x592F860", VA = "0x185930C60")]
		[FreeFunction("MaterialScripting::SetPass", HasExplicitThis = true)]
		[MethodImpl(4096)]
		public extern bool SetPass(int pass);

		// Token: 0x06000449 RID: 1097
		[Token(Token = "0x6000449")]
		[Address(RVA = "0x592FB80", Offset = "0x592E780", VA = "0x18592FB80")]
		[FreeFunction("MaterialScripting::CopyPropertiesFrom", HasExplicitThis = true)]
		[MethodImpl(4096)]
		public extern void CopyPropertiesFromMaterial(Material mat);

		// Token: 0x0600044A RID: 1098
		[Token(Token = "0x600044A")]
		[Address(RVA = "0x5930000", Offset = "0x592EC00", VA = "0x185930000")]
		[FreeFunction("MaterialScripting::GetShaderKeywords", HasExplicitThis = true)]
		[MethodImpl(4096)]
		private extern string[] GetShaderKeywords();

		// Token: 0x0600044B RID: 1099
		[Token(Token = "0x600044B")]
		[Address(RVA = "0x5930CA0", Offset = "0x592F8A0", VA = "0x185930CA0")]
		[FreeFunction("MaterialScripting::SetShaderKeywords", HasExplicitThis = true)]
		[MethodImpl(4096)]
		private extern void SetShaderKeywords(string[] names);

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x0600044C RID: 1100 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600044D RID: 1101 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700010B")]
		public string[] shaderKeywords
		{
			[Token(Token = "0x600044C")]
			[Address(RVA = "0x5930000", Offset = "0x592EC00", VA = "0x185930000")]
			get
			{
				return null;
			}
			[Token(Token = "0x600044D")]
			[Address(RVA = "0x5930CA0", Offset = "0x592F8A0", VA = "0x185930CA0")]
			set
			{
			}
		}

		// Token: 0x0600044E RID: 1102
		[Token(Token = "0x600044E")]
		[Address(RVA = "0x592FB40", Offset = "0x592E740", VA = "0x18592FB40")]
		[MethodImpl(4096)]
		public extern int ComputeCRC();

		// Token: 0x0600044F RID: 1103
		[Token(Token = "0x600044F")]
		[Address(RVA = "0x5930900", Offset = "0x592F500", VA = "0x185930900")]
		[NativeName("SetFloatFromScript")]
		[MethodImpl(4096)]
		private extern void SetFloatImpl(int name, float value);

		// Token: 0x06000450 RID: 1104 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000450")]
		[Address(RVA = "0x59307D0", Offset = "0x592F3D0", VA = "0x1859307D0")]
		[NativeName("SetColorFromScript")]
		private void SetColorImpl(int name, Color value)
		{
		}

		// Token: 0x06000451 RID: 1105 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000451")]
		[Address(RVA = "0x5930B00", Offset = "0x592F700", VA = "0x185930B00")]
		[NativeName("SetMatrixFromScript")]
		private void SetMatrixImpl(int name, Matrix4x4 value)
		{
		}

		// Token: 0x06000452 RID: 1106
		[Token(Token = "0x6000452")]
		[Address(RVA = "0x5930CF0", Offset = "0x592F8F0", VA = "0x185930CF0")]
		[NativeName("SetTextureFromScript")]
		[MethodImpl(4096)]
		private extern void SetTextureImpl(int name, Texture value);

		// Token: 0x06000453 RID: 1107
		[Token(Token = "0x6000453")]
		[Address(RVA = "0x59306B0", Offset = "0x592F2B0", VA = "0x1859306B0")]
		[NativeName("SetBufferFromScript")]
		[MethodImpl(4096)]
		private extern void SetBufferImpl(int name, ComputeBuffer value);

		// Token: 0x06000454 RID: 1108
		[Token(Token = "0x6000454")]
		[Address(RVA = "0x592FF50", Offset = "0x592EB50", VA = "0x18592FF50")]
		[NativeName("GetFloatFromScript")]
		[MethodImpl(4096)]
		private extern float GetFloatImpl(int name);

		// Token: 0x06000455 RID: 1109 RVA: 0x00003240 File Offset: 0x00001440
		[Token(Token = "0x6000455")]
		[Address(RVA = "0x592FDA0", Offset = "0x592E9A0", VA = "0x18592FDA0")]
		[NativeName("GetColorFromScript")]
		private Color GetColorImpl(int name)
		{
			return default(Color);
		}

		// Token: 0x06000456 RID: 1110
		[Token(Token = "0x6000456")]
		[Address(RVA = "0x5930140", Offset = "0x592ED40", VA = "0x185930140")]
		[NativeName("GetTextureFromScript")]
		[MethodImpl(4096)]
		private extern Texture GetTextureImpl(int name);

		// Token: 0x06000457 RID: 1111 RVA: 0x00003258 File Offset: 0x00001458
		[Token(Token = "0x6000457")]
		[Address(RVA = "0x59302D0", Offset = "0x592EED0", VA = "0x1859302D0")]
		[NativeName("GetTextureScaleAndOffsetFromScript")]
		private Vector4 GetTextureScaleAndOffsetImpl(int name)
		{
			return default(Vector4);
		}

		// Token: 0x06000458 RID: 1112 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000458")]
		[Address(RVA = "0x5930D90", Offset = "0x592F990", VA = "0x185930D90")]
		[NativeName("SetTextureOffsetFromScript")]
		private void SetTextureOffsetImpl(int name, Vector2 offset)
		{
		}

		// Token: 0x06000459 RID: 1113 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000459")]
		[Address(RVA = "0x5930EC0", Offset = "0x592FAC0", VA = "0x185930EC0")]
		[NativeName("SetTextureScaleFromScript")]
		private void SetTextureScaleImpl(int name, Vector2 scale)
		{
		}

		// Token: 0x0600045A RID: 1114 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600045A")]
		[Address(RVA = "0x59309D0", Offset = "0x592F5D0", VA = "0x1859309D0")]
		public void SetInt(string name, int value)
		{
		}

		// Token: 0x0600045B RID: 1115 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600045B")]
		[Address(RVA = "0x5930A50", Offset = "0x592F650", VA = "0x185930A50")]
		public void SetInt(int nameID, int value)
		{
		}

		// Token: 0x0600045C RID: 1116 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600045C")]
		[Address(RVA = "0x5930950", Offset = "0x592F550", VA = "0x185930950")]
		public void SetFloat(string name, float value)
		{
		}

		// Token: 0x0600045D RID: 1117 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600045D")]
		[Address(RVA = "0x5930900", Offset = "0x592F500", VA = "0x185930900")]
		public void SetFloat(int nameID, float value)
		{
		}

		// Token: 0x0600045E RID: 1118 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600045E")]
		[Address(RVA = "0x5930870", Offset = "0x592F470", VA = "0x185930870")]
		public void SetColor(string name, Color value)
		{
		}

		// Token: 0x0600045F RID: 1119 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600045F")]
		[Address(RVA = "0x5930820", Offset = "0x592F420", VA = "0x185930820")]
		public void SetColor(int nameID, Color value)
		{
		}

		// Token: 0x06000460 RID: 1120 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000460")]
		[Address(RVA = "0x59310B0", Offset = "0x592FCB0", VA = "0x1859310B0")]
		public void SetVector(string name, Vector4 value)
		{
		}

		// Token: 0x06000461 RID: 1121 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000461")]
		[Address(RVA = "0x5931020", Offset = "0x592FC20", VA = "0x185931020")]
		public void SetVector(int nameID, Vector4 value)
		{
		}

		// Token: 0x06000462 RID: 1122 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000462")]
		[Address(RVA = "0x5930B50", Offset = "0x592F750", VA = "0x185930B50")]
		public void SetMatrix(string name, Matrix4x4 value)
		{
		}

		// Token: 0x06000463 RID: 1123 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000463")]
		[Address(RVA = "0x5930BF0", Offset = "0x592F7F0", VA = "0x185930BF0")]
		public void SetMatrix(int nameID, Matrix4x4 value)
		{
		}

		// Token: 0x06000464 RID: 1124 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000464")]
		[Address(RVA = "0x5930FA0", Offset = "0x592FBA0", VA = "0x185930FA0")]
		public void SetTexture(string name, Texture value)
		{
		}

		// Token: 0x06000465 RID: 1125 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000465")]
		[Address(RVA = "0x5930CF0", Offset = "0x592F8F0", VA = "0x185930CF0")]
		public void SetTexture(int nameID, Texture value)
		{
		}

		// Token: 0x06000466 RID: 1126 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000466")]
		[Address(RVA = "0x5930700", Offset = "0x592F300", VA = "0x185930700")]
		public void SetBuffer(string name, ComputeBuffer value)
		{
		}

		// Token: 0x06000467 RID: 1127 RVA: 0x00003270 File Offset: 0x00001470
		[Token(Token = "0x6000467")]
		[Address(RVA = "0x592FF90", Offset = "0x592EB90", VA = "0x18592FF90")]
		public float GetFloat(string name)
		{
			return 0f;
		}

		// Token: 0x06000468 RID: 1128 RVA: 0x00003288 File Offset: 0x00001488
		[Token(Token = "0x6000468")]
		[Address(RVA = "0x592FF50", Offset = "0x592EB50", VA = "0x18592FF50")]
		public float GetFloat(int nameID)
		{
			return 0f;
		}

		// Token: 0x06000469 RID: 1129 RVA: 0x000032A0 File Offset: 0x000014A0
		[Token(Token = "0x6000469")]
		[Address(RVA = "0x592FE00", Offset = "0x592EA00", VA = "0x18592FE00")]
		public Color GetColor(string name)
		{
			return default(Color);
		}

		// Token: 0x0600046A RID: 1130 RVA: 0x000032B8 File Offset: 0x000014B8
		[Token(Token = "0x600046A")]
		[Address(RVA = "0x592FEA0", Offset = "0x592EAA0", VA = "0x18592FEA0")]
		public Color GetColor(int nameID)
		{
			return default(Color);
		}

		// Token: 0x0600046B RID: 1131 RVA: 0x000032D0 File Offset: 0x000014D0
		[Token(Token = "0x600046B")]
		[Address(RVA = "0x59304A0", Offset = "0x592F0A0", VA = "0x1859304A0")]
		public Vector4 GetVector(string name)
		{
			return default(Vector4);
		}

		// Token: 0x0600046C RID: 1132 RVA: 0x000032E8 File Offset: 0x000014E8
		[Token(Token = "0x600046C")]
		[Address(RVA = "0x5930540", Offset = "0x592F140", VA = "0x185930540")]
		public Vector4 GetVector(int nameID)
		{
			return default(Vector4);
		}

		// Token: 0x0600046D RID: 1133 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600046D")]
		[Address(RVA = "0x5930430", Offset = "0x592F030", VA = "0x185930430")]
		public Texture GetTexture(string name)
		{
			return null;
		}

		// Token: 0x0600046E RID: 1134 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600046E")]
		[Address(RVA = "0x5930140", Offset = "0x592ED40", VA = "0x185930140")]
		public Texture GetTexture(int nameID)
		{
			return null;
		}

		// Token: 0x0600046F RID: 1135 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600046F")]
		[Address(RVA = "0x5930DE0", Offset = "0x592F9E0", VA = "0x185930DE0")]
		public void SetTextureOffset(string name, Vector2 value)
		{
		}

		// Token: 0x06000470 RID: 1136 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000470")]
		[Address(RVA = "0x5930D90", Offset = "0x592F990", VA = "0x185930D90")]
		public void SetTextureOffset(int nameID, Vector2 value)
		{
		}

		// Token: 0x06000471 RID: 1137 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000471")]
		[Address(RVA = "0x5930F10", Offset = "0x592FB10", VA = "0x185930F10")]
		public void SetTextureScale(string name, Vector2 value)
		{
		}

		// Token: 0x06000472 RID: 1138 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000472")]
		[Address(RVA = "0x5930EC0", Offset = "0x592FAC0", VA = "0x185930EC0")]
		public void SetTextureScale(int nameID, Vector2 value)
		{
		}

		// Token: 0x06000473 RID: 1139 RVA: 0x00003300 File Offset: 0x00001500
		[Token(Token = "0x6000473")]
		[Address(RVA = "0x59301F0", Offset = "0x592EDF0", VA = "0x1859301F0")]
		public Vector2 GetTextureOffset(string name)
		{
			return default(Vector2);
		}

		// Token: 0x06000474 RID: 1140 RVA: 0x00003318 File Offset: 0x00001518
		[Token(Token = "0x6000474")]
		[Address(RVA = "0x5930180", Offset = "0x592ED80", VA = "0x185930180")]
		public Vector2 GetTextureOffset(int nameID)
		{
			return default(Vector2);
		}

		// Token: 0x06000475 RID: 1141 RVA: 0x00003330 File Offset: 0x00001530
		[Token(Token = "0x6000475")]
		[Address(RVA = "0x59303A0", Offset = "0x592EFA0", VA = "0x1859303A0")]
		public Vector2 GetTextureScale(string name)
		{
			return default(Vector2);
		}

		// Token: 0x06000476 RID: 1142 RVA: 0x00003348 File Offset: 0x00001548
		[Token(Token = "0x6000476")]
		[Address(RVA = "0x5930330", Offset = "0x592EF30", VA = "0x185930330")]
		public Vector2 GetTextureScale(int nameID)
		{
			return default(Vector2);
		}

		// Token: 0x06000477 RID: 1143
		[Token(Token = "0x6000477")]
		[Address(RVA = "0x5930780", Offset = "0x592F380", VA = "0x185930780")]
		[MethodImpl(4096)]
		private extern void SetColorImpl_Injected(int name, ref Color value);

		// Token: 0x06000478 RID: 1144
		[Token(Token = "0x6000478")]
		[Address(RVA = "0x5930AB0", Offset = "0x592F6B0", VA = "0x185930AB0")]
		[MethodImpl(4096)]
		private extern void SetMatrixImpl_Injected(int name, ref Matrix4x4 value);

		// Token: 0x06000479 RID: 1145
		[Token(Token = "0x6000479")]
		[Address(RVA = "0x592FD50", Offset = "0x592E950", VA = "0x18592FD50")]
		[MethodImpl(4096)]
		private extern void GetColorImpl_Injected(int name, out Color ret);

		// Token: 0x0600047A RID: 1146
		[Token(Token = "0x600047A")]
		[Address(RVA = "0x5930280", Offset = "0x592EE80", VA = "0x185930280")]
		[MethodImpl(4096)]
		private extern void GetTextureScaleAndOffsetImpl_Injected(int name, out Vector4 ret);

		// Token: 0x0600047B RID: 1147
		[Token(Token = "0x600047B")]
		[Address(RVA = "0x5930D40", Offset = "0x592F940", VA = "0x185930D40")]
		[MethodImpl(4096)]
		private extern void SetTextureOffsetImpl_Injected(int name, ref Vector2 offset);

		// Token: 0x0600047C RID: 1148
		[Token(Token = "0x600047C")]
		[Address(RVA = "0x5930E70", Offset = "0x592FA70", VA = "0x185930E70")]
		[MethodImpl(4096)]
		private extern void SetTextureScaleImpl_Injected(int name, ref Vector2 scale);
	}
}
