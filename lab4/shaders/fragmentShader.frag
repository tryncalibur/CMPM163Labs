uniform sampler2D texture1;
varying vec2 vUv;
uniform vec3 checker;

void main() {
	if(checker.x != checker.y) {
		gl_FragColor = texture2D(texture1, vUv);
	}

	else{
		vec2 v = vUv * 2.0;
		if (v.x > 1.0)
			v.x = v.x - 1.0;
		if (v.y > 1.0)
			v.y = v.y - 1.0;
		gl_FragColor = texture2D(texture1, v);
	}
	
}
