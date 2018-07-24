﻿namespace CapPuccino.Opcodes
{
    public enum JcOpcodes : byte
    {
        //javacard list of supported opcode
        aaload = 0x24,
        aastore = 0x37,
        aconst_null = 0x01,
        aload = 0x15,
        aload_0 = 0x18,
        aload_1 = 0x19,
        aload_2 = 0x1a,
        aload_3 = 0x1b,
        anewarray = 0x91,
        areturn = 0x77,
        arraylength = 0x92,
        astore = 0x28,
        astore_0 = 0x2b,
        astore_1 = 0x2c,
        astore_2 = 0x2d,
        astore_3 = 0x2e,
        athrow = 0x93,
        baload = 0x25,
        bastore = 0x38,
        bipush = 0x12,
        bspush = 0x10,
        checkcast = 0x94,
        dup = 0x3d,
        dup_x = 0x3f,
        dup2 = 0x3e,
        getfield_a = 0x83,
        getfield_b = 0x84,
        getfield_s = 0x85,
        getfield_i = 0x86,
        getfield_a_this = 0xad,
        getfield_b_this = 0xae,
        getfield_s_this = 0xaf,
        getfield_i_this = 0xb0,
        getfield_a_w = 0xa9,
        getfield_b_w = 0xaa,
        getfield_s_w = 0xab,
        getfield_i_w = 0xac,
        getstatic_a = 0x7b,
        getstatic_b = 0x7c,
        getstatic_s = 0x7d,
        getstatic_i = 0x7e,
        _goto   = 0x70,
        goto_w = 0xa8,
        i2b = 0x5d,
        i2s = 0x5e,
        iadd = 0x42,
        iaload = 0x27,
        iand = 0x54,
        iastore = 0x3a,
        icmp = 0x5f,
        iconst_m1 = 0x09,
        iconst_0 = 0x0a,
        iconst_1 = 0x0b,
        iconst_2 = 0x0c,
        iconst_3 = 0x0d,
        iconst_4 = 0x0e,
        iconst_5 = 0x0f,
        idiv = 0x48,
        if_acmpeq = 0x68,
        if_acmpne = 0x69,
        if_acmpeq_w = 0xa0,
        if_acmpne_w = 0xa1,
        if_scmpeq = 0x6a,
        if_scmpne = 0x6b,
        if_scmplt = 0x6c,
        if_scmpge = 0x6d,
        if_scmpgt = 0x6e,
        if_scmple = 0x6f,
        if_scmpeq_w = 0xa2,
        if_scmpne_w = 0xa3,
        if_scmplt_w = 0xa4,
        if_scmpge_w = 0xa5,
        if_scmpgt_w = 0xa6,
        if_scmple_w = 0xa7,
        ifeq = 0x60,
        ifne = 0x61,
        iflt = 0x62,
        ifge = 0x63,
        ifgt = 0x64,
        ifle = 0x65,
        ifeq_w = 0x98,
        ifne_w = 0x99,
        iflt_w = 0x9a,
        ifge_w = 0x9b,
        ifgt_w = 0x9c,
        ifle_w = 0x9d,
        ifnonnull = 0x67,
        ifnonnull_w = 0x9f,
        ifnull = 0x66,
        ifnull_w = 0x9e,
        iinc = 0x5a,
        iinc_w = 0x97,
        iipush = 0x14,
        iload = 0x17,
        iload_0 = 0x20,
        iload_1 = 0x21,
        iload_2 = 0x22,
        iload_3 = 0x23,
        ilookupswitch = 0x76,
        imul = 0x46,
        ineg = 0x4c,
        instanceof = 0x95,
        invokeinterface = 0x8e,
        invokespecial = 0x8c,
        invokestatic = 0x8d,
        invokevirtual = 0x8b,
        ior = 0x56,
        irem = 0x4a,
        ireturn = 0x79,
        ishl = 0x4e,
        ishr = 0x50,
        istore = 0x2a,
        istore_0 = 0x33,
        istore_1 = 0x34,
        istore_2 = 0x35,
        istore_3 = 0x36,
        isub = 0x44,
        itableswitch = 0x74,
        iushr = 0x52,
        ixor = 0x58,
        jsr = 0x71,
        _new = 0x8f,
        newarray = 0x90,
        nop = 0,
        pop = 0x3b,
        pop2 = 0x3c,
        putfield_a = 0x87,
        putfield_b = 0x88,
        putfield_s = 0x89,
        putfield_i = 0x8a,
        putfield_a_this = 0xb5,
        putfield_b_this = 0xb6,
        putfield_s_this = 0xb7,
        putfield_i_this = 0xb8,
        putfield_a_w = 0xb1,
        putfield_b_w = 0xb2,
        putfield_s_w = 0xb3,
        putfield_i_w = 0xb4,
        putstatic_a = 0x7f,
        putstatic_b = 0x80,
        putstatic_s = 0x81,
        putstatic_i = 0x82,
        ret = 0x72,
        Return = 0x7a,
        s2b = 0x5b,
        s2i = 0x5c,
        sadd = 0x41,
        saload = 0x26,
        sand = 0x53,
        sastore = 0x39,
        sconst_m1 = 0x02,
        sconst_0 = 0x03,
        sconst_1 = 0x04,
        sconst_2 = 0x05,
        sconst_3 = 0x06,
        sconst_4 = 0x07,
        sconst_5 = 0x08,
        sdiv = 0x47,
        sinc = 0x59,
        sinc_w = 0x96,
        sipush = 0x13,
        sload = 0x16,
        sload_0 = 0x1c,
        sload_1 = 0x1d,
        sload_2 = 0x1e,
        sload_3 = 0x1f,
        slookupswitch = 0x75,
        smul = 0x45,
        sneg = 0x4b,
        sor = 0x55,
        srem = 0x49,
        sreturn = 0x78,
        sshl = 0x4d,
        sshr = 0x4f,
        sspush = 0x11,
        sstore = 0x29,
        sstore_0 = 0x2f,
        sstore_1 = 0x30,
        sstore_2 = 0x31,
        sstore_3 = 0x32,
        ssub = 0x43,
        stableswitch = 0x73,
        sushr = 0x51,
        swap_x = 0x40,
        sxor = 0x57        
    }
}
