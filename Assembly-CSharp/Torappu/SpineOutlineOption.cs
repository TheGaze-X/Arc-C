using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Torappu.Battle;
using UnityEngine;
using XLua;

namespace Torappu
{
	// Token: 0x02000541 RID: 1345
	[Token(Token = "0x2000541")]
	public class SpineOutlineOption : IHotfixable
	{
		// Token: 0x17000C8B RID: 3211
		// (get) Token: 0x06005A35 RID: 23093 RVA: 0x0002E890 File Offset: 0x0002CA90
		// (set) Token: 0x06005A36 RID: 23094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C8B")]
		public bool isEnabled
		{
			[Token(Token = "0x6005A35")]
			[Address(RVA = "0x1AFBE00", Offset = "0x1AFAA00", VA = "0x181AFBE00")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005A36")]
			[Address(RVA = "0x1AFBE60", Offset = "0x1AFAA60", VA = "0x181AFBE60")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06005A37 RID: 23095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A37")]
		[Address(RVA = "0x1AFBCC0", Offset = "0x1AFA8C0", VA = "0x181AFBCC0")]
		public SpineOutlineOption(UnitAnimator unitAnimator, BattleOutlineConfig config, Shader outlineShader)
		{
		}

		// Token: 0x06005A38 RID: 23096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A38")]
		[Address(RVA = "0x1AFB820", Offset = "0x1AFA420", VA = "0x181AFB820")]
		public void UpdateOutlineOption([Optional] UnitAnimator animator, bool force = false)
		{
		}

		// Token: 0x06005A39 RID: 23097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A39")]
		[Address(RVA = "0x1AFB250", Offset = "0x1AF9E50", VA = "0x181AFB250")]
		public void DoLateUpdate()
		{
		}

		// Token: 0x04001FFE RID: 8190
		[Token(Token = "0x4001FFE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private UnitAnimator m_animator;

		// Token: 0x04001FFF RID: 8191
		[Token(Token = "0x4001FFF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Dictionary<Renderer, Material> m_materials;

		// Token: 0x04002000 RID: 8192
		[Token(Token = "0x4002000")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Material m_currentMaterial;

		// Token: 0x04002001 RID: 8193
		[Token(Token = "0x4002001")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Renderer m_currentRender;

		// Token: 0x04002002 RID: 8194
		[Token(Token = "0x4002002")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private MeshFilter m_currentMeshFilter;

		// Token: 0x04002003 RID: 8195
		[Token(Token = "0x4002003")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private Transform m_currentTransform;

		// Token: 0x04002004 RID: 8196
		[Token(Token = "0x4002004")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private BattleOutlineConfig m_config;

		// Token: 0x04002005 RID: 8197
		[Token(Token = "0x4002005")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private Shader m_outlineShader;

		// Token: 0x04002006 RID: 8198
		[Token(Token = "0x4002006")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private bool m_isEnabled;

		// Token: 0x04002008 RID: 8200
		[Token(Token = "0x4002008")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isEnabled;

		// Token: 0x04002009 RID: 8201
		[Token(Token = "0x4002009")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_isEnabled;

		// Token: 0x0400200A RID: 8202
		[Token(Token = "0x400200A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0400200B RID: 8203
		[Token(Token = "0x400200B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_UpdateOutlineOption;

		// Token: 0x0400200C RID: 8204
		[Token(Token = "0x400200C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_DoLateUpdate;
	}
}
